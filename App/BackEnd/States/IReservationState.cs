using BackEnd.Models;

namespace BackEnd.States
{
    public interface IReservationState
    {
        void ProcessPayment(Reservation reservation);
        void Cancel(Reservation reservation);
    }
}
