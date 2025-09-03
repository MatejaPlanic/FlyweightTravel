namespace BackEnd.Config
{
    using System.Data;
    using System.IO;

    public sealed class DatabaseManager
    {
        private static DatabaseManager? instance = null;
        private static readonly object padlock = new object();
        private readonly IBroker dbBroker;

        private DatabaseManager(string configFilePath)
        {
            if (configFilePath.ToLower().Contains("config1"))
            {
                this.dbBroker = SqliteBroker.GetInstance(configFilePath);
            }
            else if (configFilePath.ToLower().Contains("config2"))
            {
                this.dbBroker = MySqlBroker.GetInstance(configFilePath);
            }
            else
            {
                throw new NotSupportedException("Nepodržan tip baze podataka ili konfiguracioni fajl.");
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
        public IDbConnection GetConnection()
        {
            return this.dbBroker.GetDB();
        }

        public IDbCommand CreateCommand()
        {
            return this.dbBroker.CreateCommand();
        }
    }
}
