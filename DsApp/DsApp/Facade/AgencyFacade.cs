using DsApp.Builders;
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

        public void AddNewPackage(TravelPackageBuilder tr)
        {
            packageService.AddNewPackage(tr);
        }

        public ClientService GetClientService()
        { return clientService; }

        public PackageService GetPackageService() { return packageService; }

        public ReservationService GetReservationService() { return reservationService; }
    }
}
