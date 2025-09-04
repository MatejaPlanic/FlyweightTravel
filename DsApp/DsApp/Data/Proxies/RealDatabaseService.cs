using DsApp.Builders;
using DsApp.Config;
using DsApp.Models;
using DsApp.Services;
using Front;
using Microsoft.Data.Sqlite;
using MySqlConnector;
using System.Data;

namespace DsApp.Data.Proxies
{
    public class RealDatabaseService
    {
        private DatabaseManager? _databaseManager = DatabaseManager.GetInstance("../../../Config/config1.txt");

        public void AddClient(string ime, string prezime,
        string brojPasosa, string datumRodjenja, string emailAdresa, string brojTelefona)
        {
                string query = "INSERT INTO client (Ime, Prezime, BrojPasosa, DatumRodjenja, EmailAdresa, BrojTelefona) " +
                               "VALUES (@ime, @prezime, @brojPasosa, @datumRodjenja, @emailAdresa, @brojTelefona);";
                _databaseManager.GetConnection().Open();
                using (var command = _databaseManager.CreateCommand())
                {
                command.CommandText = query;
                command.Connection = _databaseManager.GetConnection();
                IDbDataParameter paramIme = command.CreateParameter();
                paramIme.ParameterName = "@ime";
                paramIme.Value = ime;
                command.Parameters.Add(paramIme);

                IDbDataParameter paramPrezime = command.CreateParameter();
                paramPrezime.ParameterName = "@prezime";
                paramPrezime.Value = prezime;
                command.Parameters.Add(paramPrezime);

                IDbDataParameter paramBrojPasosa = command.CreateParameter();
                paramBrojPasosa.ParameterName = "@brojPasosa";
                paramBrojPasosa.Value = brojPasosa;
                command.Parameters.Add(paramBrojPasosa);

                IDbDataParameter paramDatumRodjenja = command.CreateParameter();
                paramDatumRodjenja.ParameterName = "@datumRodjenja";
                paramDatumRodjenja.Value = datumRodjenja;
                command.Parameters.Add(paramDatumRodjenja);

                IDbDataParameter paramEmailAdresa = command.CreateParameter();
                paramEmailAdresa.ParameterName = "@emailAdresa";
                paramEmailAdresa.Value = emailAdresa;
                command.Parameters.Add(paramEmailAdresa);

                IDbDataParameter paramBrojTelefona = command.CreateParameter();
                paramBrojTelefona.ParameterName = "@brojTelefona";
                paramBrojTelefona.Value = brojTelefona;
                command.Parameters.Add(paramBrojTelefona);

                command.ExecuteNonQuery();
                }
            _databaseManager.GetConnection().Close();

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
