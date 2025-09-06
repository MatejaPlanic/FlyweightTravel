using DsApp.Models;
using DsApp.ViewModels;

namespace DsApp.States
{
    public class UpdatedState : IReservationState
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
            return "Ažurirana";
        }

        public override string ToString() => "Ažurirana";

    }
}
