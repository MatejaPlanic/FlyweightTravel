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
    public partial class Novi_Paket : Form
    {
        public Novi_Paket()
        {
            InitializeComponent();
        }

        private void Novi_Paket_Load(object sender, EventArgs e)
        {
            comboBox_tip.Items.Add("More");
            comboBox_tip.Items.Add("Planina");
            comboBox_tip.Items.Add("Ekskurzija");
            comboBox_tip.Items.Add("Krstarenje");
        }
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_fill.Controls.Add(childForm);
            panel_fill.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void comboBox_tip_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Prvo, zatvori prethodnu child formu ako postoji
            // if (activeForm != null)
            // {
            //     activeForm.Close();
            //     activeForm = null; // Resetuj child form
            // }

            // Na osnovu izabrane opcije u ComboBox-u, otvori odgovarajuću formu
            switch (comboBox_tip.SelectedItem.ToString())
            {
                case "More":
                    
                    openChildForm(new PaketAranzmanZaMore());
                    break;
                case "Planina":
                    
                    openChildForm(new PaketAranzmanZaPlanine());
                    break;
                case "Ekskurzija":
                    
                    openChildForm(new PaketEkskurzije());
                    break;
                case "Krstarenje":
                    
                    openChildForm(new PaketKrstarenje());
                    break;
                default:
                    MessageBox.Show("Molimo odaberite formu iz ComboBox-a.");
                    return;
            }
        }
    }
}
