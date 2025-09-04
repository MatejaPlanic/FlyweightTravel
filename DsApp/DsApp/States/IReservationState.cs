using DsApp.Models;

namespace DsApp.States
{
    public interface IReservationState
    {
        void ProcessPayment(Reservation reservation);
        void Cancel(Reservation reservation);
    }
}
