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
    public partial class PaketAranzmanZaPlanine : Form
    {
        public PaketAranzmanZaPlanine()
        {
            InitializeComponent();
        }
        public string Destination
        {
            get => planina_destinacija.Text;
        }

        public string Accommodation
        {
            get => planina_smestaj.Text;
        }

        public string Transport
        {
            get => planina_prevoz.Text;
        }

        public string Dodatne
        {
            get => planina_dodatne.Text;
        }


        private void PaketAranzmanZaPlanine_Load(object sender, EventArgs e)
        {

        }
    }
}
