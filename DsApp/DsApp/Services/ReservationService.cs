using DsApp.Data.Proxies;
using DsApp.Models;

namespace DsApp.Services
{
    public class ReservationService
    {
        private DatabaseProxy? proxy = null;

        public ReservationService()
        {
            proxy = DatabaseProxy.getProxy();
        }

        public List<Reservation> GetAllReservations(int id)
        {
            return proxy.GetAllReservations(id);
        }
        public void AddNewReservation(string destinacija, int tipId, int broj_osoba, int klijentId)
        {
            proxy.AddNewReservation(destinacija,tipId,broj_osoba,klijentId);
        }

        public void CancelReservation(int id)
        {
            proxy.CancelReservation(id);
        }
    }
}
