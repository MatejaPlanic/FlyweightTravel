using DsApp.Config;
using DsApp.Data.Proxies;
using DsApp.Models;

namespace DsApp.Services
{
    public class ReservationService
    {
        private DatabaseProxy? proxy = null;
        private static ReservationService? instance = null;
        private static readonly object padlock = new object();
        private ReservationService()
        {
            proxy = DatabaseProxy.getProxy();
        }
        public static ReservationService GetInstance()
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new ReservationService();
                }
                return instance;
            }

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

        public void DeleteReservation(int id)
        {
            proxy.DeleteReservation(id);
        }

        public void UpdateReservation(int id, string destinacija, int tip_id, int broj_osoba)
        {
            if (id < 0) throw new ArgumentOutOfRangeException(nameof(id));
            if (string.IsNullOrWhiteSpace(destinacija)) throw new ArgumentException("Destinacija je obavezna.", nameof(destinacija));
            if (tip_id < 0) throw new ArgumentOutOfRangeException(nameof(tip_id));
            if (broj_osoba <= 0) throw new ArgumentOutOfRangeException(nameof(broj_osoba));

            proxy.UpdateReservation(id,destinacija,tip_id,broj_osoba);
        }
    }
}
