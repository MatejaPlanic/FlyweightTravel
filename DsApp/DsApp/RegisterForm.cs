using DsApp;
using DsApp.Facade;
using DsApp.Observers;
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
using DsApp.ViewModels;
namespace Front
{
    public partial class RegisterForm : Form, DsApp.Observers.IObserver<string>
    {
        private readonly AgencyFacade _facade = AgencyFacade.GetInstance();
        public RegisterForm()
        {
            InitializeComponent();
            comboBox1.SelectionChangeCommitted += comboBox1_Changed;
            DatabaseNotifier.GetInstance().Attach(this);
        }

        public int idKlijent
        {
            get
            {
                if (comboBox1.SelectedValue is int v) return v;
                return int.TryParse(comboBox1.SelectedValue?.ToString(), out var id)
                    ? id : 0;
            }
        }


        private void RegisterForm_Load(object sender, EventArgs e)
        {
            try
            {
                guna2DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                guna2DataGridView1.MultiSelect = false;
                guna2DataGridView1.ReadOnly = true;
                var korisnici = _facade.GetAllClients();

                // Projekcija: Id + prikazno ime
                var items = korisnici
                    .Select(k => new
                    {
                        Id = k.ID,
                        Name = $"{k.Ime} {k.Prezime}"
                    })
                    .ToList();
                items.Insert(0, new { Id = -1, Name = "Izaberite korisnika" });
                comboBox1.BeginUpdate();
                comboBox1.DataSource = null;
                comboBox1.Items.Clear();

                comboBox1.DataSource = items;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Id";
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBox1.SelectedIndex = items.Count > 0 ? 0 : -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ne mogu da učitam klijente: " + ex.Message);
            }
            finally
            {
                comboBox1.EndUpdate();
            }
        }

        private void button_dodaj_Click(object sender, EventArgs e)
        {
            int currentClientId = idKlijent;
            if(currentClientId == -1)
            {
                MessageBox.Show("Izaberite klijenta");
                return;
            }
            RezervacijaPaketa noviPaket = new RezervacijaPaketa(currentClientId, guna2DataGridView1);
            noviPaket.ShowDialog();
        }
        private int? GetSelectedReservationId()
        {
            var row = guna2DataGridView1.CurrentRow;
            if (row == null) return null;

            var data = row.DataBoundItem;
            if (data == null) return null;

            var prop = data.GetType().GetProperty("ID");
            if (prop == null) return null;

            var val = prop.GetValue(data);
            if (val is int i) return i;

            return int.TryParse(val?.ToString(), out var parsed) ? parsed : (int?)null;
        }
        private void button_otkazi_Click(object sender, EventArgs e)
        {
            var id = GetSelectedReservationId();
            if (id == null)
            {
                MessageBox.Show("Izaberite rezervaciju koju želite da otkažete.");
                return;
            }
            var row = guna2DataGridView1.CurrentRow?.DataBoundItem as ReservationRow;
            if (row.state.Cancel(row) == false)
            {
                MessageBox.Show("Ne možete otkazati već otkazanu rezervaciju");
                return;
            }
            var potvrdjeno = MessageBox.Show(
            "Otkazati izabranu rezervaciju?",
            "Potvrda",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (potvrdjeno != DialogResult.Yes) return;

            try
            {

                _facade.CancelReservation(id.Value);
                MessageBox.Show("Uspešno otkazana rezervacija");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri otkazivanju: " + ex.Message);
            }
        }
        public Guna2DataGridView GetGuna
        {
            get => guna2DataGridView1;
        }
        private void comboBox1_Changed(object sender, EventArgs e)
        {

            int clientId = idKlijent;
            var rezervacije = _facade.GetAllReservations(clientId);
            var rows = rezervacije.Select(r => new ReservationRow
            {
                ID = r.ID,
                Paket = r.PackageName,
                Datum = r.ReservationDate,
                Status = r.State?.ToString() ?? "",
                BrojOsoba = r.Broj_osoba,
                Destinacija = r.Destinacija,
                state = r.State
            }).ToList();
            guna2DataGridView1.DataSource = rows;

            if (guna2DataGridView1.Columns.Contains("ID"))
                guna2DataGridView1.Columns["ID"].Visible = false;

            if (guna2DataGridView1.Columns.Contains("state"))
                guna2DataGridView1.Columns["state"].Visible = false;
        }

        public void Update(string data)
        {
            if (data == "res_change")
            {
                comboBox1_Changed(null, null);
            }
        }

        private void button_azuriraj_Click(object sender, EventArgs e)
        {
            var row = guna2DataGridView1.CurrentRow?.DataBoundItem as ReservationRow;
            if (row == null)
            {
                MessageBox.Show("Izaberite rezervaciju koju želite da ažurirate.");
                return;
            }
            if(row.state.Update(row) == false)
            {
                MessageBox.Show("Ne možete ažurirati otkazanu rezervaciju");
                return;
            }

            var frm = new AzuriranjeRezervacija(row); 
            frm.ShowDialog();
        }

        private void button_obrisi_Click(object sender, EventArgs e)
        {
            var id = GetSelectedReservationId();
            if (id == null)
            {
                MessageBox.Show("Izaberite rezervaciju koju želite da obrišete.");
                return;
            }

            var potvrdjeno = MessageBox.Show(
            "Obrisati izabranu rezervaciju?",
            "Potvrda",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (potvrdjeno != DialogResult.Yes) return;

            try
            {

                _facade.DeleteReservation(id.Value);
                MessageBox.Show("Uspešno obrisana rezervacija");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri brisanju: " + ex.Message);
            }
        }
    }
}
