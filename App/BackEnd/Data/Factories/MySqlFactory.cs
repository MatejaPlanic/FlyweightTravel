using BackEnd.Config;
using System.Data;

namespace BackEnd.Data.Factories
{
    public class MySqlFactory : DatabaseFactory
    {
        private IBroker? db = null;
        public override IBroker CreateConnection(string con)
        {
            this.db = MySqlBroker.GetInstance(con);

            return this.db;
        }

    }
}
