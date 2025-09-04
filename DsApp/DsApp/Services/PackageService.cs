using DsApp.Builders;
using DsApp.Data.Proxies;

namespace DsApp.Services
{
    public class PackageService
    {
        private DatabaseProxy? proxy = null;

        public PackageService()
        {
            proxy = DatabaseProxy.getProxy();
        }
        public void AddNewPackage(TravelPackageBuilder tr)
        {
            proxy.AddNewPackage(tr);
        }

    }
}
