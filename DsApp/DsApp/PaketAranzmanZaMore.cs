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
    public partial class PaketAranzmanZaMore : Form
    {
        public PaketAranzmanZaMore()
        {
            InitializeComponent();
        }

        private void PaketAranzmanZaMore_Load(object sender, EventArgs e)
        {

        }
        public string DestinationText
        {
            get => more_destinacija.Text;
        }

        public string AccommodationText
        {
            get => more_smestaj.Text;
        }

        public string TransportText
        {
            get => more_prevoz.Text;
        }
    }
}
