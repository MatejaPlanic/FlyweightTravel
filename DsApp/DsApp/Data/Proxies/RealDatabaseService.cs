using DsApp.Config;
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
