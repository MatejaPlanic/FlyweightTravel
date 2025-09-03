using MySqlConnector;
using System.Data;


namespace BackEnd.Config
{
    public class MySqlBroker : IBroker
    {
        private static MySqlBroker? instance = null;
        private static readonly object padlock = new object();
        private string agencyName;
        private string connectionString;
        private readonly IDbConnection db;
        private MySqlBroker(string configFilePath)
        {
            string[] lines = System.IO.File.ReadAllLines(configFilePath);
            this.agencyName = lines[0];
            this.connectionString = lines[1];
            this.db = new MySqlConnection(this.connectionString);
        }

        public static IBroker GetInstance(string configFilePath)
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new MySqlBroker(configFilePath);
                }
                return instance;
            }
        }
        public string GetAgencyName() { return this.agencyName; }
        public string GetConnectionString() { return this.connectionString; }
        public IDbConnection GetDB() { return this.db; }
        public IDbCommand CreateCommand() { return new MySqlCommand(); }
    }
}
