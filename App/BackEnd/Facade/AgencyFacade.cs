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

        public void AddNewClient(string name, string passportNumber)
        {
            //clientService.AddClient(name, passportNumber);
        }

        public List<Client> GetAllClients()
        {
            //return clientService.GetClients();
            return null;
        }

        public void ReservePackageForClient(int clientId, int packageId)
        {
            //reservationService.CreateReservation(clientId, packageId);
        }

        // ... ostale metode za rad sa podacima
    }
}
