using DsApp.Facade;
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
    public partial class DodajKlijenta : Form
    {
        public DodajKlijenta()
        {
            InitializeComponent();
        }

        private void DodajKlijenta_Load(object sender, EventArgs e)
        {

        }

        private void button_dodaj_paket_Click(object sender, EventArgs e)
        {
            AgencyFacade af = AgencyFacade.GetInstance();

            af.AddNewClient(klijent_ime.Text, klijent_prezime.Text,klijent_pasos.Text,klijent_datum.Text
                ,klijent_email.Text,klijent_telefon.Text);
        }
    }
}
