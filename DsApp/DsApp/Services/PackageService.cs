using DsApp.Builders;
using DsApp.Config;
using DsApp.Data.Proxies;

namespace DsApp.Services
{
    public class PackageService
    {
        private DatabaseProxy? proxy = null;
        private static PackageService? instance = null;
        private static readonly object padlock = new object();
        private PackageService()
        {
            proxy = DatabaseProxy.getProxy();
        }

        public static PackageService GetInstance()
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new PackageService();
                }
                return instance;
            }

        }

        public void AddNewPackage(TravelPackageBuilder tr)
        {
            if (tr == null) throw new ArgumentNullException(nameof(tr));
            proxy.AddNewPackage(tr);
        }
        public List<TravelPackage> GetAllPackages()
        {
            return proxy.GetAllPackages();
        }
        public List<string> GetAllDestinations()
        {
            return proxy.GetAllDestinations();
        }
        public List<(string Name, int Id)> GetAllPackageDestinationNames(string dest)
        {
            return proxy.GetAllPackageDestinationNames(dest);
        }
    }
}
