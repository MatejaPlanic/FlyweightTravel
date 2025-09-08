using DsApp.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DsApp.ViewModels
    {
        public sealed class ReservationRow
        {
            public int ID { get; set; }
            public string Paket { get; set; } = "";
            public string Datum { get; set; } = "";
            public string Status { get; set; } = "";
            public int BrojOsoba { get; set; }
            public string Destinacija { get; set; } = "";

            public IReservationState state { get; set; }
        }
    }


