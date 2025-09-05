namespace DsApp.Config
{
    using DsApp.Config;
    using Microsoft.Data.Sqlite;
    using MySqlConnector;
    using System.Data;
    using System.IO;

    public sealed class DatabaseManager
    {
        private static DatabaseManager? instance = null;
        private static readonly object padlock = new object();
        private static IBroker dbBroker;
        private static string? _connectionString;

        public static void Initialize(string configFile) // ../../../Config/
        {
            
            if (configFile.ToLower().Contains("config1")) //Sqlite
            {
                string[] lines = System.IO.File.ReadAllLines(configFile);
                var dbPath = lines[1].Split(';')[0].Split('=')[1];

                if (!File.Exists(dbPath))
                {

                    var stream = File.Create(dbPath);
                        
                }
            }
            DatabaseManager.SetConnectionString(configFile);
        }
        public static void SetConnectionString(string connectionString)
        {
            _connectionString = connectionString;
            if (_connectionString.ToLower().Contains("config1"))
            {
                dbBroker = SqliteBroker.GetInstance(_connectionString);

                using (var connection = DatabaseManager.GetInstance().GetConnection())
                {
                    connection.Open();

                    // SQL za kreiranje 'client' tabele
                    var createClientTableQuery = "CREATE TABLE IF NOT EXISTS client (" +
                                                 "id INTEGER NOT NULL UNIQUE, " +
                                                 "ime TEXT NOT NULL, " +
                                                 "prezime TEXT NOT NULL, " +
                                                 "brojpasosa TEXT NOT NULL, " +
                                                 "datumrodjenja TEXT NOT NULL, " +
                                                 "emailadresa TEXT, " +
                                                 "brojtelefona TEXT, " +
                                                 "PRIMARY KEY(\"id\" AUTOINCREMENT));";

                    using (var command = new SqliteCommand(createClientTableQuery, (SqliteConnection)connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    // SQL za kreiranje 'packages' tabele
                    var createPackageTableQuery = "CREATE TABLE IF NOT EXISTS packages (" +
                                                  "id INTEGER NOT NULL UNIQUE, " +
                                                  "ime TEXT, " +
                                                  "destinacija TEXT, " +
                                                  "transport TEXT, " +
                                                  "smestaj TEXT, " +
                                                  "cena NUMERIC, " +
                                                  "dodatne_aktivnosti TEXT, " +
                                                  "vodic TEXT, " +
                                                  "trajanje TEXT, " +
                                                  "brod TEXT, " +
                                                  "ruta TEXT, " +
                                                  "datum_polaska TEXT, " +
                                                  "tip_kabine TEXT, " +
                                                  "tip_paketa TEXT, " +
                                                  "PRIMARY KEY(\"id\" AUTOINCREMENT));";

                    using (var command = new SqliteCommand(createPackageTableQuery, (SqliteConnection)connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    // SQL za kreiranje 'reservations' tabele
                    var createReservationsTableQuery = "CREATE TABLE IF NOT EXISTS reservations (" +
                                                       "id INTEGER NOT NULL UNIQUE, " +
                                                       "id_client INTEGER NOT NULL, " +
                                                       "id_package INTEGER NOT NULL, " +
                                                       "state TEXT, " +
                                                       "datum_rezervacije TEXT NOT NULL, " +
                                                       "PRIMARY KEY(\"id\" AUTOINCREMENT));";

                    using (var command = new SqliteCommand(createReservationsTableQuery, (SqliteConnection)connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            else if (_connectionString.ToLower().Contains("config2"))
            {
                dbBroker = MySqlBroker.GetInstance(_connectionString);
                string[] lines = System.IO.File.ReadAllLines(connectionString);
                // Izdvoji ime baze iz connection stringa
                var dbName = lines[1].Split(';')[1].Split('=')[1];

                // Kreiraj novi connection string bez imena baze, samo za konekciju na server
                var serverConnectionString = $"Server=localhost;Uid=root;Pwd=;Port=3306;";
                    using (var connection = new MySqlConnection(serverConnectionString))
                    {
                        connection.Open();
                        var query = $"CREATE DATABASE IF NOT EXISTS `{dbName}`;";
                        using (var command = new MySqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                using (var connection = new MySqlConnection(lines[1]))
                {
                    connection.Open();

                    
                    var createClientTableQuery = "CREATE TABLE IF NOT EXISTS client (" +
                                                 "id INT PRIMARY KEY AUTO_INCREMENT, " +
                                                 "ime VARCHAR(255) NOT NULL, " +
                                                 "prezime VARCHAR(255) NOT NULL, " +
                                                 "brojpasosa VARCHAR(255) NOT NULL, " +
                                                 "datumrodjenja VARCHAR(255) NOT NULL, " +
                                                 "emailadresa VARCHAR(255), " +
                                                 "brojtelefona VARCHAR(255));";

                    using (var command = new MySqlCommand(createClientTableQuery, (MySqlConnection)connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    
                    var createPackageTableQuery = "CREATE TABLE IF NOT EXISTS packages (" +
                                                  "id INT PRIMARY KEY AUTO_INCREMENT, " +
                                                  "ime VARCHAR(255), " +
                                                  "destinacija VARCHAR(255), " +
                                                  "transport VARCHAR(255), " +
                                                  "smestaj VARCHAR(255), " +
                                                  "cena DECIMAL(10, 2), " +
                                                  "dodatne_aktivnosti VARCHAR(255), " +
                                                  "vodic VARCHAR(255), " +
                                                  "trajanje VARCHAR(255), " +
                                                  "brod VARCHAR(255), " +
                                                  "ruta VARCHAR(255), " +
                                                  "datum_polaska VARCHAR(255), " +
                                                  "tip_kabine VARCHAR(255), " +
                                                  "tip_paketa VARCHAR(255));";

                    using (var command = new MySqlCommand(createPackageTableQuery, (MySqlConnection)connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    
                    var createReservationsTableQuery = "CREATE TABLE IF NOT EXISTS reservations (" +
                                                       "id INT PRIMARY KEY AUTO_INCREMENT, " +
                                                       "id_client INT NOT NULL, " +
                                                       "id_package INT NOT NULL, " +
                                                       "state VARCHAR(255), " +
                                                       "datum_rezervacije VARCHAR(255));";

                    using (var command = new MySqlCommand(createReservationsTableQuery, (MySqlConnection)connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                
            }
        }

        public static string GetName()
        {
            return dbBroker.GetAgencyName();
        }

        private DatabaseManager()
        {

        }

        public static DatabaseManager GetInstance()
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new DatabaseManager();
                }
                return instance;
            }
        }
        public IDbConnection GetConnection()
        {
            return dbBroker.GetDB();
        }

        public IDbCommand CreateCommand()
        {
            return dbBroker.CreateCommand();
        }
    }
}
