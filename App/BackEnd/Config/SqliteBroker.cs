using Microsoft.Data.Sqlite;
using System.Data;
using SQLitePCL;

namespace BackEnd.Config
{
    public class SqliteBroker : IBroker
    {
        private static SqliteBroker? instance = null;
        private static readonly object padlock = new object();
        private string agencyName;
        private string connectionString;
        private readonly SqliteConnection db;

        private SqliteBroker(string configFilePath)
        {
            SQLitePCL.Batteries_V2.Init();
            string[] lines = System.IO.File.ReadAllLines(configFilePath);
            if (lines.Length >= 2)
            {
                this.agencyName = lines[0];
                this.connectionString = lines[1];
                this.db = new SqliteConnection(this.connectionString);
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
                    instance = new SqliteBroker(configFilePath);
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

        public SqliteConnection getDB()
        { return this.db; }
    }
}
