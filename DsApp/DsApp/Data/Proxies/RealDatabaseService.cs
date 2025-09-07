using DsApp.Builders;
using DsApp.Config;
using DsApp.Facade;
using DsApp.Models;
using DsApp.Observers;
using DsApp.Services;
using DsApp.States;
using Front;
using Microsoft.Data.Sqlite;
using MySqlConnector;
using System.Data;
using System.Globalization;

namespace DsApp.Data.Proxies
{
    public class RealDatabaseService
    {
        private static RealDatabaseService? instance = null;
        private DatabaseManager? _databaseManager = DatabaseManager.GetInstance();
        private DatabaseNotifier _notifier = DatabaseNotifier.GetInstance();
        private static readonly object padlock = new object();
        private RealDatabaseService()
        { 
        
        }

        public static RealDatabaseService GetInstance()
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new RealDatabaseService();
                }
                return instance;
            }
        }

        public void AddClient(SqlEnvelope envelope)
        {
            if (envelope is null) throw new ArgumentNullException(nameof(envelope));
            if (string.IsNullOrWhiteSpace(envelope.Query))
                throw new ArgumentException("Query je prazan.", nameof(envelope));

            var conn = _databaseManager!.GetConnection();
            try
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = envelope.Query;
                    cmd.Connection = conn;

                    foreach (var kv in envelope.Parameters)
                    {
                        var p = cmd.CreateParameter();
                        p.ParameterName = kv.Key;
                        p.Value = kv.Value ?? DBNull.Value;
                        cmd.Parameters.Add(p);
                    }

                    cmd.ExecuteNonQuery();
                    _notifier.NotifyClientsChanged();
                }
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }

        }

        public List<Client> GetAllClients()
        {
            List<Client> clients = new List<Client>();
            string query = "SELECT * FROM client;";

            try
            {
                _databaseManager.GetConnection().Open();
                using (var command = _databaseManager.CreateCommand())
                {
                    command.CommandText = query;
                    command.Connection = _databaseManager.GetConnection();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clients.Add(new Client(
                            
                                reader.GetInt32(0),
                                reader["ime"].ToString(),
                                reader["prezime"].ToString(),
                                reader["brojpasosa"].ToString(),
                                reader["datumrodjenja"].ToString(),
                                reader["emailadresa"].ToString(),
                                reader["brojtelefona"].ToString()
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                _databaseManager.GetConnection().Close();
            }

            return clients;
        }

        public List<Client> SearchClients(string srch)
        {
            var clients = new List<Client>();
            string query = "SELECT id, ime, prezime, brojpasosa, datumrodjenja, emailadresa, brojtelefona FROM client " +
                           "WHERE ime LIKE @ime OR prezime LIKE @prezime;";

            _databaseManager.GetConnection().Open();
            
                using (var command = _databaseManager.CreateCommand())
                {
                    command.CommandText = query;
                    command.Connection = _databaseManager.GetConnection();

                IDbDataParameter paramIme = command.CreateParameter();
                    paramIme.ParameterName = "@ime";
                    paramIme.Value = "%" + srch + "%";
                    command.Parameters.Add(paramIme);

                    IDbDataParameter paramPrezime = command.CreateParameter();
                    paramPrezime.ParameterName = "@prezime";
                    paramPrezime.Value = "%" + srch + "%";
                    command.Parameters.Add(paramPrezime);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clients.Add(new Client(

                                reader.GetInt32(0),
                                reader["ime"].ToString(),
                                reader["prezime"].ToString(),
                                reader["brojpasosa"].ToString(),
                                reader["datumrodjenja"].ToString(),
                                reader["emailadresa"].ToString(),
                                reader["brojtelefona"].ToString()
                            ));
                        }
                    }
                }
            _databaseManager.GetConnection().Close();


            return clients;
        }






        public List<TravelPackage> GetAllPackages()
        {
            List<TravelPackage> packages = new List<TravelPackage>();
            string query = "SELECT * FROM packages;";

            try
            {
                _databaseManager.GetConnection().Open();
                using (var command = _databaseManager.CreateCommand())
                {
                    command.CommandText = query;
                    command.Connection = _databaseManager.GetConnection();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            switch (reader["tip_paketa"].ToString())
                            {
                                case "More":
                                        var sea = new SeaArrangementBuilder();
                                        sea.BuildCommonDetails(reader["ime"].ToString(), double.Parse(reader["cena"].ToString()), "More");
                                        sea.BuildDestination(reader["destinacija"].ToString());
                                        sea.BuildAccommodationType(reader["smestaj"].ToString());
                                        sea.BuildTransportType(reader["transport"].ToString());
                                        sea.GetPackage().Id = reader.GetInt32(0);
                                    packages.Add(sea.GetPackage());
                                    break;
                                case "Planina":
                                        var planina = new MountainArrangementBuilder();
                                        planina.BuildCommonDetails(reader["ime"].ToString(), double.Parse(reader["cena"].ToString()), "Planina");
                                        planina.BuildDestination(reader["destinacija"].ToString());
                                        planina.BuildTransportType(reader["transport"].ToString());
                                        planina.BuildAccommodationType(reader["smestaj"].ToString());
                                        planina.BuildAdditionalActivities(reader["dodatne_aktivnosti"].ToString());
                                        planina.GetPackage().Id = reader.GetInt32(0);
                                    packages.Add(planina.GetPackage());
                                    break;
                                case "Ekskurzija":
                                        var ekskurzija = new ExcursionArrangementBuilder();
                                        ekskurzija.BuildCommonDetails(reader["ime"].ToString(), double.Parse(reader["cena"].ToString()), "Ekskurzija");
                                        ekskurzija.BuildDestination(reader["destinacija"].ToString());
                                        ekskurzija.BuildGuide(reader["vodic"].ToString());
                                        ekskurzija.BuildDuration(reader["trajanje"].ToString());
                                        ekskurzija.BuildTransportType(reader["transport"].ToString());
                                        ekskurzija.GetPackage().Id = reader.GetInt32(0);
                                        packages.Add(ekskurzija.GetPackage());
                                    break;
                                case "Krstarenje":
                                        var krstarenje = new CruiseArrangementBuilder();
                                        krstarenje.BuildCommonDetails(reader["ime"].ToString(), double.Parse(reader["cena"].ToString()), "Krstarenje");
                                        krstarenje.BuildBoat(reader["brod"].ToString());
                                        krstarenje.BuildCabinType(reader["tip_kabine"].ToString());
                                        krstarenje.BuildRoute(reader["ruta"].ToString());
                                        krstarenje.BuildDateOfDeparture(reader["datum_polaska"].ToString());
                                        krstarenje.BuildDestination(reader["destinacija"].ToString());
                                        krstarenje.GetPackage().Id = reader.GetInt32(0);
                                    packages.Add(krstarenje.GetPackage());
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                _databaseManager.GetConnection().Close();
            }

            return packages;
        }

        public void AddNewPackage(SqlEnvelope envelope)
        {
            if (envelope is null) throw new ArgumentNullException(nameof(envelope));
            if (string.IsNullOrWhiteSpace(envelope.Query))
                throw new ArgumentException("Query je prazan.", nameof(envelope));

            var conn = _databaseManager!.GetConnection();
            try
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = envelope.Query;
                    cmd.Connection = conn;

                    foreach (var kv in envelope.Parameters)
                    {
                        var p = cmd.CreateParameter();
                        p.ParameterName = kv.Key;
                        p.Value = kv.Value ?? DBNull.Value;
                        cmd.Parameters.Add(p);
                    }

                    cmd.ExecuteNonQuery();
                    _notifier.NotifyPackagesChanged();
                }
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        public List<string> GetAllDestinations()
        {
            var result = new List<string>();

            const string query = @"
            SELECT DISTINCT destinacija
            FROM packages
            WHERE destinacija IS NOT NULL AND TRIM(destinacija) <> ''
            ORDER BY destinacija;";

            var conn = _databaseManager!.GetConnection();
            try
            {
                conn.Open();
                using (var cmd = _databaseManager.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                var dest = reader.GetString(0);
                                if (!string.IsNullOrWhiteSpace(dest))
                                    result.Add(dest);
                            }
                        }
                    }
                }
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }

            return result;
        }

        public List<(string Name, int Id)> GetAllPackageDestinationNames(string dest)
        {
            var result = new List<( string Name, int Id)>();
            if (string.IsNullOrWhiteSpace(dest))
                return result;

            const string query = @"
        SELECT ime,id
        FROM packages
        WHERE LOWER(TRIM(destinacija)) = LOWER(TRIM(@dest))
        ORDER BY ime;";

            var conn = _databaseManager!.GetConnection();
            try
            {
                conn.Open();
                using (var cmd = _databaseManager.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    var p = cmd.CreateParameter();
                    p.ParameterName = "@dest";
                    p.Value = dest;
                    cmd.Parameters.Add(p);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = reader.IsDBNull(1) ? 0 : Convert.ToInt32(reader.GetValue(1));
                            var name = reader.IsDBNull(0) ? "" : reader.GetString(0);

                            result.Add((name,id));
                        }
                    }
                }
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }

            return result;
        }

        public List<Reservation> GetAllReservations(int id)
        {
            var result = new List<Reservation>();
            const string query = @"
                SELECT r.id      AS res_id,
                       p.ime     AS paket,
                       r.datum_rezervacije,
                       r.state,
                       r.broj_osoba,
                       r.destinacija
                FROM reservations r
                JOIN packages p ON p.id = r.id_package
                WHERE r.id_client = @id;";
            var conn = _databaseManager!.GetConnection();

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                using (var cmd = _databaseManager.CreateCommand())
                {
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    var p = cmd.CreateParameter();
                    p.ParameterName = "@id";
                    p.Value = id;
                    cmd.Parameters.Add(p);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            var resId = !reader.IsDBNull(0) ? Convert.ToInt32(reader.GetValue(0)) : 0;
                            var paket = !reader.IsDBNull(1) ? reader.GetString(1) : "Paket";
                            var broj_osoba = !reader.IsDBNull(4) ? Convert.ToInt32(reader.GetValue(4)) : 0;
                            var destinacija = !reader.IsDBNull(5) ? reader.GetString(5) : "Destinacija";

                            var res = new Reservation(paket,broj_osoba, destinacija) { ID = resId };

                           
                            if (!reader.IsDBNull(2))
                            {
                                string dateStr;
                                var fieldType = reader.GetFieldType(2);
                                if (fieldType == typeof(DateTime))
                                {
                                    var dt = reader.GetDateTime(2);
                                    dateStr = dt.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
                                }
                                else
                                {
                                    var raw = reader.GetValue(2)?.ToString() ?? "";
                                    if (DateTime.TryParse(raw, out var dt))
                                        dateStr = dt.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
                                    else
                                        dateStr = raw; 
                                }
                                res.ReservationDate = dateStr;
                            }

                            var stateStr = !reader.IsDBNull(3) ? reader.GetString(3) : null;
                            if(stateStr == "Otkazana")
                            {
                                res.State = new CanceledState();
                            }
                            else if (stateStr == "Ažurirana")
                            {
                                res.State = new UpdatedState();
                            }
                            else if (stateStr == "Rezervisana")
                            {
                                res.State = new ReservedState();
                            }

                            result.Add(res);
                        }
                    }
                }
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }

            return result;
        }

        public void AddNewReservation(SqlEnvelope envelope)
        {
            if (envelope is null) throw new ArgumentNullException(nameof(envelope));
            if (string.IsNullOrWhiteSpace(envelope.Query))
                throw new ArgumentException("Query je prazan.", nameof(envelope));

            var conn = _databaseManager!.GetConnection();
            try
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = envelope.Query;
                    cmd.Connection = conn;

                    foreach (var kv in envelope.Parameters)
                    {
                        var p = cmd.CreateParameter();
                        p.ParameterName = kv.Key;
                        p.Value = kv.Value ?? DBNull.Value;
                        cmd.Parameters.Add(p);
                    }

                    cmd.ExecuteNonQuery();
                    _notifier.NotifyResChanged();
                }
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        public void CancelReservation(SqlEnvelope envelope)
        {
            if (envelope is null) throw new ArgumentNullException(nameof(envelope));
            if (string.IsNullOrWhiteSpace(envelope.Query))
                throw new ArgumentException("Query je prazan.", nameof(envelope));

            var conn = _databaseManager!.GetConnection();
            try
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = envelope.Query;
                    cmd.Connection = conn;

                    foreach (var kv in envelope.Parameters)
                    {
                        var p = cmd.CreateParameter();
                        p.ParameterName = kv.Key;
                        p.Value = kv.Value ?? DBNull.Value;
                        cmd.Parameters.Add(p);
                    }

                    cmd.ExecuteNonQuery();
                    _notifier.NotifyResChanged();
                }
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        public void DeleteReservation(SqlEnvelope envelope)
        {
            if (envelope is null) throw new ArgumentNullException(nameof(envelope));
            if (string.IsNullOrWhiteSpace(envelope.Query))
                throw new ArgumentException("Query je prazan.", nameof(envelope));

            var conn = _databaseManager!.GetConnection();
            try
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = envelope.Query;
                    cmd.Connection = conn;

                    foreach (var kv in envelope.Parameters)
                    {
                        var p = cmd.CreateParameter();
                        p.ParameterName = kv.Key;
                        p.Value = kv.Value ?? DBNull.Value;
                        cmd.Parameters.Add(p);
                    }

                    cmd.ExecuteNonQuery();
                    _notifier.NotifyResChanged();
                }
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        public void UpdateReservation(SqlEnvelope envelope)
        {
            if (envelope is null) throw new ArgumentNullException(nameof(envelope));
            if (string.IsNullOrWhiteSpace(envelope.Query))
                throw new ArgumentException("Query je prazan.", nameof(envelope));

            var conn = _databaseManager!.GetConnection();
            try
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = envelope.Query;
                    cmd.Connection = conn;

                    foreach (var kv in envelope.Parameters)
                    {
                        var p = cmd.CreateParameter();
                        p.ParameterName = kv.Key;
                        p.Value = kv.Value ?? DBNull.Value;
                        cmd.Parameters.Add(p);
                    }

                    cmd.ExecuteNonQuery();
                    _notifier.NotifyResChanged();
                }
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }


    }
}
