using BackEnd.Models;
using BackEnd.Services;

namespace BackEnd.Facade
{
    public class AgencyFacade
    {
        private readonly ClientService clientService;
        private readonly PackageService packageService;
        private readonly ReservationService reservationService;

        public AgencyFacade()
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

      
    }
}
