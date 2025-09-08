using DsApp.Models;
using DsApp.ViewModels;

namespace DsApp.States
{
    public class CanceledState : IReservationState
    {
        public bool Update(ReservationRow reservation)
        {
            return false;
        }
        public bool Cancel(ReservationRow reservation)
        {
            return false;
        }

        string IReservationState.getState()
        {
            return "Otkazana";
        }

        public override string ToString() => "Otkazana";
    }
}
