using Npgsql;
using System.Data;

namespace BackEnd.Config
{
    public class PostgreBroker : IBroker
    {
        private static PostgreBroker? instance = null;
        private static readonly object padlock = new object();
        private string agencyName;
        private string connectionString;
        private readonly NpgsqlConnection db;

        private PostgreBroker(string configFilePath)
        {
            string[] lines = System.IO.File.ReadAllLines(configFilePath);
            if (lines.Length >= 2)
            {
                this.agencyName = lines[0];
                this.connectionString = lines[1];
                this.db = new NpgsqlConnection(this.connectionString);
            }
            else
            {
                throw new InvalidOperationException("config1.txt fajl nije validan.");
            }
        }

        public static IBroker GetInstance(string configFilePath)
        {
            lock(padlock)
            {
                if (instance == null)
                {
                    instance = new PostgreBroker(configFilePath);
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

        public NpgsqlConnection getDB()
        { return this.db; }
    }
}
