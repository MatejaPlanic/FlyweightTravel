namespace BackEnd.Models
{
    using BackEnd.Builders;
    using BackEnd.States;
    using System;
    using System.Collections.Generic;

    public class Reservation
    {
        public int ID { get; set; }

        public Client Client { get; set; }

        public TravelPackage Package { get; set; }

        public DateTime ReservationDate { get; set; }

        public IReservationState State { get; set; }

        public Reservation(Client client, TravelPackage package)
        {
            this.Client = client;
            this.Package = package;
            this.ReservationDate = DateTime.Now;
            this.State = new ReservedState();
        }
        public void ProcessPayment()
        {
            this.State.ProcessPayment(this);
        }

        public void Cancel()
        {
            this.State.Cancel(this);
        }
    }
}
