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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Front
{
    public partial class RezervacijaPaketa : Form
    {
        private readonly AgencyFacade _facade = AgencyFacade.GetInstance();
        public RezervacijaPaketa()
        {
            InitializeComponent();
            comboBox1.SelectionChangeCommitted += ComboDestinacija_Changed;
        }


        private void button_rezervisi_Click(object sender, EventArgs e)
        {
            Main mainForm = (Main)Application.OpenForms["Main"];

            // Ako je glavna forma otvorena, pozovi openChildForm metodu da otvori "RezervisiPakete"
            if (mainForm != null)
            {
                mainForm.openChildForm(new PaketiKlijenta());
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

            comboBox_tip.BeginUpdate();
            comboBox_tip.DataSource = null;
            comboBox_tip.Items.Clear();
            comboBox_tip.DataSource = imena;           
            comboBox_tip.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_tip.EndUpdate();
        }
    }
}
