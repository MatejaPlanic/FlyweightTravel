using DsApp.Models;
using DsApp.ViewModels;

namespace DsApp.States
{
    public class ReservedState : IReservationState
    {
        public bool Update(ReservationRow reservation)
        {
            reservation.state = new UpdatedState();
            return true;
        }

        public bool Cancel(ReservationRow reservation)
        {
            reservation.state = new CanceledState();
            return true;
        }

        string IReservationState.getState()
        {
            return "Rezervisana";
        }

        public override string ToString() => "Rezervisana";
    }
}
