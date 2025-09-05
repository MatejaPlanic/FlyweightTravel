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
            return clientService.GetAllClients();
        }

        public List<TravelPackage> GetAllPackages()
        {
            return packageService.GetAllPackages();
        }

        public void ReservePackageForClient(int clientId, int packageId)
        {
            
        }

        public List<string> GetAllDestinations()
        {
            return packageService.GetAllDestinations();
        }

        public List<(string Name, int Id)> GetAllPackageDestinationNames(string dest)
        {
            return packageService.GetAllPackageDestinationNames(dest);
        }

        public void AddNewPackage(TravelPackageBuilder tr)
        {
            packageService.AddNewPackage(tr);
        }

        public List<Reservation> GetAllReservations(int id)
        {
            return reservationService.GetAllReservations(id);
        }

        public ClientService GetClientService()
        { return clientService; }

        public void AddNewReservation(string destinacija,int tipId,int broj_osoba,int klijentId)
        {
            reservationService.AddNewReservation(destinacija,tipId,broj_osoba,klijentId);
        }

        public void CancelReservation(int id)
        {
            reservationService.CancelReservation(id);
        }

        public PackageService GetPackageService() { return packageService; }

        public ReservationService GetReservationService() { return reservationService; }
    }
}
