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
    public partial class Paketi : Form
    {
        public Paketi()
        {
            InitializeComponent();
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
    }
}
