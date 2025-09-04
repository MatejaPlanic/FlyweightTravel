using System.Data;

namespace DsApp.Config
{
    public interface IBroker
    {
        public string GetConnectionString();
        public string GetAgencyName();
        public IDbConnection GetDB();
        public IDbCommand CreateCommand();
    }
}
