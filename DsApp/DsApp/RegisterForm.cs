using DsApp.Facade;
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
    public partial class RegisterForm : Form
    {
        private readonly AgencyFacade _facade = AgencyFacade.GetInstance();
        public RegisterForm()
        {
            InitializeComponent();
            comboBox1.SelectionChangeCommitted += comboBox1_Changed;
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
            RezervacijaPaketa noviPaket = new RezervacijaPaketa(currentClientId);
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

            var potvrdjeno = MessageBox.Show(
            "Otkazati izabranu rezervaciju?",
            "Potvrda",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (potvrdjeno != DialogResult.Yes) return;

            try
            {
                _facade.CancelReservation(id.Value);   
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri otkazivanju: " + ex.Message);
            }
        }

        private void comboBox1_Changed(object sender, EventArgs e)
        {

                int clientId = idKlijent;
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
            guna2DataGridView1.DataSource = rows;

            if (guna2DataGridView1.Columns.Contains("ID"))
                guna2DataGridView1.Columns["ID"].Visible = false;

        }
    }
}
