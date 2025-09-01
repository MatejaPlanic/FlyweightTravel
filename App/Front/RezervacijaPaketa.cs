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
    public partial class RezervacijaPaketa : Form
    {
        public RezervacijaPaketa()
        {
            InitializeComponent();
        }


        private void button_rezervisi_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)Application.OpenForms["Main"];

            // Ako je glavna forma otvorena, pozovi openChildForm metodu da otvori "RezervisiPakete"
            if (mainForm != null)
            {
                mainForm.openChildForm(new PaketiKlijenta());
            }
        }

        private void RezervacijaPaketa_Load(object sender, EventArgs e)
        {

        }
    }
}
