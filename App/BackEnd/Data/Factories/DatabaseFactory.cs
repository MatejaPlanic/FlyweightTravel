using BackEnd.Config;
using System.Data;

namespace BackEnd.Data.Factories
{
    public abstract class DatabaseFactory
    {
        public abstract IBroker CreateConnection(string con);
    }
}
