using System.Data;

namespace BackEnd.Config
{
    public interface IBroker
    {
        public abstract static IBroker GetInstance(string configFilePath);
        public string GetConnectionString();
        public string GetAgencyName();

        public IDbConnection getDB();
    }
}
