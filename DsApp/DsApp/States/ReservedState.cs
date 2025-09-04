using DsApp.Models;

namespace DsApp.States
{
    public class ReservedState : IReservationState
    {
        public void ProcessPayment(Reservation reservation)
        {
            Console.WriteLine("Rezervacija plaćena.");
            reservation.State = new PaidState();
        }

        public void Cancel(Reservation reservation)
        {
            Console.WriteLine("Rezervacija je otkazana.");
            reservation.State = new CanceledState();
        }
    }
}
