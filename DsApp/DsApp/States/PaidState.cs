using DsApp.Models;

namespace DsApp.States
{
    public class PaidState : IReservationState
    {
        public void ProcessPayment(Reservation reservation)
        {
            Console.WriteLine("Rezervacija je već plaćena.");
        }

        public void Cancel(Reservation reservation)
        {
            Console.WriteLine("Plaćena rezervacija je otkazana. Pokrenut proces povraćaja novca.");
            reservation.State = new CanceledState();
        }
    }
}
