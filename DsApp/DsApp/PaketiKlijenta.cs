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
    public partial class PaketiKlijenta : Form
    {
        private readonly int _clientId;
        private readonly Guna2DataGridView _dg;
        public PaketiKlijenta(int clientId, Guna2DataGridView rezs)
        {
            InitializeComponent();
            _dg = rezs;
            _clientId = clientId;
        }

        private void button_rezervisi_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)Application.OpenForms["Main"];

            // Ako je glavna forma otvorena, pozovi openChildForm metodu da otvori "RezervisiPakete"
            if (mainForm != null)
            {
                mainForm.openChildForm(new RezervacijaPaketa(_clientId, _dg));
            }
        }

        private void PaketiKlijenta_Load(object sender, EventArgs e)
        {

        }
    }
}
