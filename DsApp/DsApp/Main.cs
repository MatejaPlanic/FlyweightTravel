using DsApp.Config;
using DsApp.Facade;
using DsApp.Models;
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
    // Main.cs
    public partial class Main : Form
    {
        private Form startForm;
        public Main(Form callingForm)
        {
            InitializeComponent();
            startForm = callingForm;
        }

        private Form activeForm = null;

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_rezervacije_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());
        }

        private void button_klijenti_Click(object sender, EventArgs e)
        {
            openChildForm(new Klijenti());

            List<Client> clients = new List<Client>();

            AgencyFacade fasada = AgencyFacade.GetInstance();

            clients = fasada.GetAllClients();

            if (activeForm is Klijenti c)
            {
                c.getClientDiv.DataSource = clients;
                if (c.getClientDiv.Columns.Contains("Id"))
                {
                    c.getClientDiv.Columns["Id"].Visible = false;
                }
            }

        }

        private void button_paketi_Click(object sender, EventArgs e)
        {
            openChildForm(new Paketi());
            AgencyFacade fasada = AgencyFacade.GetInstance();
            if (activeForm is Paketi p)
            {
                var paketi = fasada.GetAllPackages();
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
                p.getPaketiDiv.DataSource = rows;
            }
        }

        private void button_izlaz_Click(object sender, EventArgs e)
        {


            //this.Hide();
            //startForm.Show();
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            label_naziv.Text = DatabaseManager.GetName();
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;   // X (Close)

            if (m.Msg == WM_SYSCOMMAND)
            {
                int command = m.WParam.ToInt32() & 0xFFF0;

                if (command == SC_CLOSE)
                {
                    // Kliknuto na X
                    Application.Exit(); // gasi celu aplikaciju
                    return;             // prekida normalno ponašanje
                }

            }

            base.WndProc(ref m); // ako ništa ne menjaš, zovi original
        }

        private void label_naziv_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
