using DsApp.Models;

namespace DsApp.States
{
    public class UpdatedState : IReservationState
    {
        public void Update(Reservation reservation)
        {
            Console.WriteLine("Rezervacija je već ažurirana.");
        }

        public void Cancel(Reservation reservation)
        {
            Console.WriteLine("Ažurirana rezervacija je otkazana.");
            reservation.State = new CanceledState();
        }

        string IReservationState.getState()
        {
            return "Ažurirana";
        }

        public override string ToString() => "Ažurirana";

    }
}
