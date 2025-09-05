using DsApp.Data.Proxies;
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
    public partial class Klijenti : Form, DsApp.Observers.IObserver<string>
    {
        RealDatabaseService rdb;
        AgencyFacade af = AgencyFacade.GetInstance();
        public Klijenti()
        {
            InitializeComponent();
            rdb = RealDatabaseService.GetInstance();
            DatabaseNotifier.GetInstance().Attach(this);
        }

        private void Klijenti_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            div_clients.DataSource = af.SearchClients(textBox_pretraga.Text);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox_pretraga_TextChanged(object sender, EventArgs e)
        {

        }

        public Guna2DataGridView getClientDiv
        {
            get => div_clients;
            
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            DodajKlijenta noviKlijent = new DodajKlijenta();
            noviKlijent.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Update(string data)
        {
            if (data == "client_added")
            {
                div_clients.DataSource = af.GetAllClients();
            }
        }
    }
}

