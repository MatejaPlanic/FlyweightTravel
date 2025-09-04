using DsApp.Config;
using DsApp.Models;
using DsApp.Services;

namespace DsApp.Facade
{
    public class AgencyFacade
    {
        private readonly ClientService clientService;
        private readonly PackageService packageService;
        private readonly ReservationService reservationService;
        private static readonly object padlock = new object();
        private static AgencyFacade? instance = null;
        private AgencyFacade()
        {
            clientService = new ClientService();
            packageService = new PackageService();
            reservationService = new ReservationService();
        }

        public void AddNewClient(string ime, string prezime, 
            string brojPasosa, string datumRodjenja, string emailAdresa, string brojTelefona)
        {
            clientService.AddClient(ime,prezime,brojPasosa,datumRodjenja,emailAdresa,brojTelefona);
        }
        public static AgencyFacade GetInstance()
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new AgencyFacade();
                }
                return instance;
            }
        }
        public List<Client> GetAllClients()
        {
          
            return null;
        }

        public void ReservePackageForClient(int clientId, int packageId)
        {
            
        }

        public void AddNewPackage(string name,string destination, string transportType, string accommodationType, double price, string additionalActivities,  string guide, double duration, string boat, string route, string dateOfDeparture,string cabinType, string packageType)
        {
            packageService.AddNewPackage(name,destination,transportType,accommodationType,price,additionalActivities,guide,duration,boat,route,dateOfDeparture,
                                   cabinType, packageType);
        }

        public ClientService GetClientService()
        { return clientService; }

        public PackageService GetPackageService() { return packageService; }

        public ReservationService GetReservationService() { return reservationService; }
    }
}
