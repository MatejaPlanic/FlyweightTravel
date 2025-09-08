using DsApp.Facade;
using DsApp.Observers;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class Paketi : Form, DsApp.Observers.IObserver<string>
    {
        AgencyFacade af = AgencyFacade.GetInstance();
        public Paketi()
        {
            InitializeComponent();
            DatabaseNotifier.GetInstance().Attach(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            Novi_Paket noviPaket = new Novi_Paket();
            noviPaket.ShowDialog();
        }

        public Guna2DataGridView getPaketiDiv
        {
            get => div_paketi;
        }
        private void Paketi_Load(object sender, EventArgs e)
        {

        }

        public void Update(string data)
        {
            if (data == "package_added")
            {
                var paketi = af.GetAllPackages();
                var rows = paketi.Select(r => new
                {
                    Naziv = r.Name,
                    Destinacija = r.Destination,
                    Transport = r.TransportType,
                    Smestaj = r.AccommodationType,
                    Cena = r.Price,
                    Info = r.AdditionalActivities,
                    Vodic = r.Guide,
                    Trajanje = r.Duration,
                    Brod = r.Boat,
                    Ruta = r.Route,
                    Polazak = r.DateOfDeparture,
                    Kabina = r.CabinType,
                    Paket = r.PackageType
                }).ToList();
                div_paketi.DataSource = rows;
            }
        }
    }
}
