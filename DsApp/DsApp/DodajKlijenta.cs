using DsApp.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            string emailRegexPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (klijent_ime.Text == "")
            {
                MessageBox.Show("Unesite Ime");
                return;
            }

            else if (klijent_prezime.Text == "")
            {
                MessageBox.Show("Unesite Prezime");
                return;
            }

            else if(klijent_pasos.Text == "")
            {
                MessageBox.Show("Unesite Broj pasoša");
                return;
            }

            else if(klijent_datum.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Datum ne sme biti u budućnosti.");
                return;
            }
            else if(!Regex.IsMatch(klijent_email.Text, emailRegexPattern))
            {
                MessageBox.Show("Email adresa nije u ispravnom formatu.");
                return;
            }

            else if(!Regex.IsMatch(klijent_telefon.Text, @"^\d+$"))
            {
                MessageBox.Show("Broj telefona može sadržati samo cifre (0–9).");
                return;
            }

            af.AddNewClient(klijent_ime.Text, klijent_prezime.Text,klijent_pasos.Text,klijent_datum.Text
                ,klijent_email.Text,klijent_telefon.Text);

            MessageBox.Show("Uspesno ste dodali korisnika");
            this.Close();
        }
    }
}
