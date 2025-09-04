using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class PaketKrstarenje : Form
    {

       

        public PaketKrstarenje()
        {
            InitializeComponent();
            krstarenje_datum.Format = DateTimePickerFormat.Custom;
            krstarenje_datum.CustomFormat = "dd.MM.yyyy";
        }
        private void label_dodatne_aktivnosti_Click(object sender, EventArgs e)
        {

        }

        public string Boat
        {
            get => krstarenje_brod.Text;
        }

        public string Route
        {
            get => krstarenje_ruta.Text;
        }

        public string Kabina
        {
            get => krstarenje_kabina.Text;
        }

        public string DepartureDate
        {
            get => krstarenje_datum.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
        }
    }
}
