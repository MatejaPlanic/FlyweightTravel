using BackEnd.Config;
using Microsoft.Data.Sqlite;
using MySqlConnector;

namespace BackEnd.Data.Proxies
{
    public class RealDatabaseService
    {
        public void AddClient(string ime, string prezime,
        string brojPasosa, string datumRodjenja, string emailAdresa, string brojTelefona)
        {
            string query = "INSERT INTO client (Ime, Prezime, BrojPasosa, DatumRodjenja, EmailAdresa, BrojTelefona) " +
                           "VALUES (@ime, @prezime, @brojPasosa, @datumRodjenja, @emailAdresa, @brojTelefona);";

            SqliteBroker ker = (SqliteBroker)SqliteBroker.GetInstance("./Config/config1.txt");
            ker.getDB().Open();
                using (var command = new SqliteCommand(query, (SqliteConnection)ker.getDB()))
                {
                    command.Parameters.AddWithValue("@ime", ime);
                    command.Parameters.AddWithValue("@prezime", prezime);
                    command.Parameters.AddWithValue("@brojPasosa", brojPasosa);
                    command.Parameters.AddWithValue("@datumRodjenja", datumRodjenja);
                    command.Parameters.AddWithValue("@emailAdresa", emailAdresa);
                    command.Parameters.AddWithValue("@brojTelefona", brojTelefona);

                    command.ExecuteNonQuery();
                }
            ker.getDB().Close();
            
        }
    }
}
