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
        public void AddNewPackage(string name, string destination, string transportType, string accommodationType, double price, string additionalActivities, string guide, double duration, string boat, string route, string dateOfDeparture,
                                  string cabinType, string packageType)
        {
            proxy.AddNewPackage(name, destination, transportType, accommodationType, price, additionalActivities, guide, duration, boat, route, dateOfDeparture,
                                   cabinType, packageType);
        }

    }
}
