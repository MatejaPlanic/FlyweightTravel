namespace DsApp.Models
{
    using DsApp.Builders;
    using DsApp.States;
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public class Reservation
    {
        public int ID { get; set; }

        public string PackageName { get; set; }

        public int Broj_osoba { get; set; }

        public string Destinacija { get; set; }

        public string ReservationDate { get; set; }

        public IReservationState State { get; set; }

        public Reservation(string package,int osobe,string dest)
        { 
            this.PackageName = package;
            this.ReservationDate = DateTime.Now.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);
            this.State = new ReservedState();
            this.Broj_osoba = osobe;
            this.Destinacija = dest;
        }
    }
}
