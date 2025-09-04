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
    public partial class PaketEkskurzije : Form
    {
        public PaketEkskurzije()
        {
            InitializeComponent();
        }

        private void textBox_naziv_TextChanged(object sender, EventArgs e)
        {

        }

        public string Destination
        {
            get => ekskurzija_destinacija.Text;
        }

        public string Guide
        {
            get => ekskurzija_vodic.Text;
        }
        public string Transport
        {
            get => ekskurzija_prevoz.Text;
        }
        public string Duration
        {
            get => ekskurzija_trajanje.Text;
        }
    }
}
