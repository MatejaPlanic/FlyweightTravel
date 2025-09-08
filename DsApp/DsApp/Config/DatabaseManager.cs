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
        private static string? _filePath;
        private static BackupManager bm;
        public static void Initialize(string configFile) // ../../../Config/
        {
            DatabaseManager.SetUp(configFile);
        }
        private static void SetUp(string filePath)
        {
            string[] lines = System.IO.File.ReadAllLines(filePath);
            _filePath = filePath;
            bm = BackupManager.GetInstance(filePath);
            if (lines[1].Contains("Data Source="))
            {
                var dbPath = lines[1].Split(';')[0].Split('=')[1];

                if (!File.Exists(dbPath))
                {
                    using (File.Create(dbPath)) { }
                }
                dbBroker = SqliteBroker.GetInstance(_filePath);
                var connection = new SqliteConnection(lines[1]);
                if (connection.State != ConnectionState.Open)
                    connection.Open();

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

                    var createReservationsTableQuery = "CREATE TABLE IF NOT EXISTS reservations (" +
                                                         "id INTEGER NOT NULL UNIQUE, " +
                                                         "id_client INTEGER NOT NULL, " +
                                                         "id_package INTEGER NOT NULL, " +
                                                         "state TEXT, " +
                                                         "datum_rezervacije TEXT NOT NULL, " +
                                                         "broj_osoba INTEGER, " +
                                                         "destinacija TEXT, " +
                                                         "PRIMARY KEY(\"id\" AUTOINCREMENT));";

                    using (var command = new SqliteCommand(createReservationsTableQuery, (SqliteConnection)connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                
            }
            else if (lines[1].Contains("Server="))
            {
                dbBroker = MySqlBroker.GetInstance(_filePath);
                var dbName = lines[1].Split(';')[1].Split('=')[1];

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
                                                         "id INT NOT NULL AUTO_INCREMENT, " +
                                                         "id_client INT NOT NULL, " +
                                                         "id_package INT NOT NULL, " +
                                                         "state VARCHAR(255), " +
                                                         "datum_rezervacije VARCHAR(255) NOT NULL, " +
                                                         "broj_osoba INT, " +
                                                         "destinacija VARCHAR(255), " +
                                                         "PRIMARY KEY (id));";

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
