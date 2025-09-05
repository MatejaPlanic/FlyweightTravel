using DsApp.Models;

namespace DsApp.States
{
    public interface IReservationState
    {
        void Update(Reservation reservation);
        void Cancel(Reservation reservation);
        string getState();
    }
}
