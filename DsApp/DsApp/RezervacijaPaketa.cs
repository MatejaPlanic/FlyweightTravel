using DsApp.Facade;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Front;
using DsApp.Observers;
namespace Front
{
    public partial class RezervacijaPaketa : Form, DsApp.Observers.IObserver<string>
    {
        private readonly AgencyFacade _facade = AgencyFacade.GetInstance();
        private readonly int _clientId;
        private readonly Guna2DataGridView _dg;
        public RezervacijaPaketa(int clientId, Guna2DataGridView rezs)
        {
            InitializeComponent();
            _clientId = clientId;
            comboBox1.SelectionChangeCommitted += ComboDestinacija_Changed;
            DatabaseNotifier.GetInstance().Attach(this);
            _dg = rezs;
        }


        private void button_rezervisi_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)Application.OpenForms["Main"];

            // Ako je glavna forma otvorena, pozovi openChildForm metodu da otvori "RezervisiPakete"
            if (mainForm != null)
            {
                mainForm.openChildForm(new PaketiKlijenta(_clientId, _dg));
            }
        }

        private void RezervacijaPaketa_Load(object sender, EventArgs e)
        {
            try
            {
                var destinacije = _facade.GetAllDestinations();

                destinacije.Insert(0, "Izaberite destinaciju");
                comboBox1.BeginUpdate();
                comboBox1.DataSource = null;
                comboBox1.Items.Clear();
                comboBox1.DataSource = destinacije;
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox1.SelectedIndex = destinacije.Count > 0 ? 0 : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ne mogu da učitam destinacije: " + ex.Message);
            }
            finally
            {
                comboBox1.EndUpdate();
            }
        }

        private void label_tip_Click(object sender, EventArgs e)
        {

        }

        private void ComboDestinacija_Changed(object? sender, EventArgs e)
        {
            var dest = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(dest)) return;

            // Pozovi fasadu
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



            _facade.AddNewReservation(destinacija, tip_id, broj_osoba, _clientId);
            MessageBox.Show("Uspesno ste dodali rezervaciju");
            this.Close();
        }

        public void Update(string data)
        {
            if (data == "res_change")
            {
                int clientId = _clientId;
                var rezervacije = _facade.GetAllReservations(clientId);
                var rows = rezervacije.Select(r => new
                {
                    ID = r.ID,
                    Paket = r.PackageName,
                    Datum = r.ReservationDate,
                    Status = r.State?.ToString(),
                    BrojOsoba = r.Broj_osoba,
                    Destinacija = r.Destinacija
                }).ToList();

                _dg.DataSource = rows;

                if (_dg.Columns.Contains("ID"))
                    _dg.Columns["ID"].Visible = false;
            }
        }
    }
}
