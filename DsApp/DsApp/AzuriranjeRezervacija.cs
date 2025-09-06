using DsApp.Facade;
using DsApp.ViewModels;
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

namespace DsApp
{
    public partial class AzuriranjeRezervacija : Form
    {
        private readonly AgencyFacade _facade = AgencyFacade.GetInstance();
        private readonly ReservationRow _model;
        public AzuriranjeRezervacija(ReservationRow model)
        {
            InitializeComponent();
            _model = model;
            comboBox1.SelectionChangeCommitted += ComboDestinacija_Changed;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AzuriranjeRezervacija_Load(object sender, EventArgs e)
        {
            var destinacije = _facade.GetAllDestinations();

            comboBox1.BeginUpdate();
            try
            {
                comboBox1.DataSource = null;
                comboBox1.Items.Clear();
                comboBox1.DataSource = destinacije;
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

                var targetDest = _model.Destinacija ?? string.Empty;
                int idxDest = destinacije.FindIndex(d =>
                    string.Equals(d, targetDest, StringComparison.CurrentCultureIgnoreCase));
                comboBox1.SelectedIndex = idxDest >= 0 ? idxDest : -1;
            }
            finally { comboBox1.EndUpdate(); }

            var dest = comboBox1.SelectedItem?.ToString();
            var imena = string.IsNullOrWhiteSpace(dest)
                ? new List<(string Name, int Id)>()
                : _facade.GetAllPackageDestinationNames(dest);

            var items = imena.Select(t => new { t.Name, t.Id }).ToList();

            comboBox_tip.BeginUpdate();
            try
            {
                comboBox_tip.DataSource = null;
                comboBox_tip.Items.Clear();
                comboBox_tip.DisplayMember = "Name";
                comboBox_tip.ValueMember = "Id";
                comboBox_tip.DataSource = items;
                comboBox_tip.DropDownStyle = ComboBoxStyle.DropDownList;

                var targetPkg = _model.Paket ?? string.Empty;
                int idxPkg = items.FindIndex(x =>
                    string.Equals(x.Name, targetPkg, StringComparison.CurrentCultureIgnoreCase));
                comboBox_tip.SelectedIndex = idxPkg >= 0 ? idxPkg : -1;
            }
            finally { comboBox_tip.EndUpdate(); }

            textBox2.Text = _model.BrojOsoba.ToString(CultureInfo.InvariantCulture);
        }

        private void ComboDestinacija_Changed(object? sender, EventArgs e)
        {
            var dest = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(dest)) return;

            var imena = _facade.GetAllPackageDestinationNames(dest);
            var items = imena.Select(t => new { Name = t.Name, Id = t.Id }).ToList();

            comboBox_tip.BeginUpdate();
            comboBox_tip.DataSource = null;
            comboBox_tip.Items.Clear();


            comboBox_tip.DisplayMember = "Name";
            comboBox_tip.ValueMember = "Id";
            comboBox_tip.DataSource = items;
            comboBox_tip.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_tip.EndUpdate();
        }

        private void button_dodaj_rezervaciju_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                MessageBox.Show("Izaberite broj osoba");
                return;
            }
            var destinacija = comboBox1.Text;
            if (comboBox_tip.SelectedValue == null)
            {
                MessageBox.Show("Izaberite tip paketa.");
                return;
            }
            int tip_id = comboBox_tip.SelectedValue is int v
                ? v
                : Convert.ToInt32(comboBox_tip.SelectedValue);

            if (!int.TryParse(textBox2.Text, out int broj_osoba) || broj_osoba <= 0)
            {
                MessageBox.Show("Unesite ispravan broj osoba (pozitivan ceo broj).");
                return;
            }

            _facade.UpdateReservation(_model.ID,destinacija,tip_id,broj_osoba);
            MessageBox.Show("Uspesno ste ažurirali rezervaciju");
            this.Close();
        }
    }
}
