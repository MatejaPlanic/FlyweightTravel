using DsApp.Models;

namespace DsApp.States
{
    public class CanceledState : IReservationState
    {
        public void ProcessPayment(Reservation reservation)
        {
            Console.WriteLine("Otkazana rezervacija ne može biti plaćena.");
        }
        public void Cancel(Reservation reservation)
        {
            Console.WriteLine("Rezervacija je već otkazana.");
        }
    }
}
