namespace BackEnd.Config
{
    public class DatabaseManager
    {
        private static DatabaseManager instance = null;
        private static readonly object padlock = new object();
        private string agencyName;
        private string connectionString;

        private DatabaseManager(string configFilePath)
        {
            // Logika za čitanje config.txt fajla
            string[] lines = System.IO.File.ReadAllLines(configFilePath);
            if (lines.Length >= 2)
            {
                this.agencyName = lines[0]; // Prva linija: naziv agencije
                this.connectionString = lines[1]; // Druga linija: konekcioni string
            }
            else
            {
                throw new InvalidOperationException("config.txt fajl nije validan.");
            }
        }

        public static DatabaseManager GetInstance(string configFilePath)
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new DatabaseManager(configFilePath);
                }
                return instance;
            }
        }

        public string GetAgencyName()
        {
            return this.agencyName;
        }

        public string GetConnectionString()
        {
            return this.connectionString;
        }
    }
}
