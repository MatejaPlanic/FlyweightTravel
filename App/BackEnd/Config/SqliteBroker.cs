using Microsoft.Data.Sqlite;
using MySqlConnector;
using SQLitePCL;
using System.Data;

namespace BackEnd.Config
{
    public class SqliteBroker : IBroker
    {
        private static SqliteBroker? instance = null;
        private static readonly object padlock = new object();
        private string agencyName;
        private string connectionString;
        private readonly IDbConnection db;
        private SqliteBroker(string configFilePath)
        {
            SQLitePCL.Batteries_V2.Init();
            string[] lines = System.IO.File.ReadAllLines(configFilePath);
            this.agencyName = lines[0];
            this.connectionString = lines[1];
            this.db = new SqliteConnection(this.connectionString);
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
        public string GetAgencyName() { return this.agencyName; }
        public string GetConnectionString() { return this.connectionString; }
        public IDbConnection GetDB() { return this.db; }
        public IDbCommand CreateCommand() { return new SqliteCommand(); }
    }
}
