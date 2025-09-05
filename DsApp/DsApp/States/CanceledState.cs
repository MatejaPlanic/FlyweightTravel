using DsApp.Models;

namespace DsApp.States
{
    public class CanceledState : IReservationState
    {
        public void Update(Reservation reservation)
        {
            Console.WriteLine("Otkazana rezervacija ne može biti ažurirana.");
        }
        public void Cancel(Reservation reservation)
        {
            Console.WriteLine("Rezervacija je već otkazana.");
        }

        string IReservationState.getState()
        {
            return "Otkazana";
        }

        public override string ToString() => "Otkazana";
    }
}
