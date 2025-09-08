using DsApp.Models;
using DsApp.ViewModels;

namespace DsApp.States
{
    public interface IReservationState
    {
        bool Update(ReservationRow reservation);
        bool Cancel(ReservationRow reservation);
        string getState();
    }
}
