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
    public partial class Klijenti : Form
    {
        public Klijenti()
        {
            InitializeComponent();
        }

        private void Klijenti_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox_pretraga_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_test_Click(object sender, EventArgs e)
        {
            // Pronađi glavnu formu (Main)
            Main mainForm = (Main)Application.OpenForms["Main"];

            // Ako je glavna forma otvorena, pozovi openChildForm metodu
            if (mainForm != null)
            {
                mainForm.openChildForm(new PaketiKlijenta());
            }
        }
    }
}

