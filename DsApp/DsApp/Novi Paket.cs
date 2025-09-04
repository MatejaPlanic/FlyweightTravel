using DsApp.Builders;
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

        private void button_dodaj_paket_Click(object sender, EventArgs e)
        {
            AgencyFacade af = AgencyFacade.GetInstance();
            switch (comboBox_tip.SelectedItem.ToString())
            {
                case "More":
                    if (activeForm is PaketAranzmanZaMore moreForm)
                    {
                        var sea = new SeaArrangementBuilder();
                        if (!double.TryParse(textBox2.Text, out var cena))
                        {
                            MessageBox.Show("Neispravna cena.");
                            return;
                        }

                        sea.BuildCommonDetails(textBox_naziv.Text, cena, "More");
                        sea.BuildDestination(moreForm.DestinationText);
                        sea.BuildAccommodationType(moreForm.AccommodationText);
                        sea.BuildAccommodationType(moreForm.TransportText);
                        af.AddNewPackage(sea);
                    }
                    break;
                case "Planina":

                    if (activeForm is PaketAranzmanZaPlanine planineForm)
                    {
                        var planina = new MountainArrangementBuilder();
                        if (!double.TryParse(textBox2.Text, out var cena))
                        {
                            MessageBox.Show("Neispravna cena.");
                            return;
                        }
                        planina.BuildCommonDetails(textBox_naziv.Text, cena, "Planina");
                        planina.BuildDestination(planineForm.Destination);
                        planina.BuildTransportType(planineForm.Transport);
                        planina.BuildAccommodationType(planineForm.Accommodation);
                        planina.BuildAdditionalActivities(planineForm.Dodatne);
                        af.AddNewPackage(planina);
                    }
                    break;
                case "Ekskurzija":
                    if (activeForm is PaketEkskurzije ekskurzijaForm)
                    {
                        var ekskurzija = new ExcursionArrangementBuilder();
                        if (!double.TryParse(textBox2.Text, out var cena))
                        {
                            MessageBox.Show("Neispravna cena.");
                            return;
                        }
                        ekskurzija.BuildCommonDetails(textBox_naziv.Text, cena, "Ekskurzija");
                        ekskurzija.BuildDestination(ekskurzijaForm.Destination);
                        ekskurzija.BuildGuide(ekskurzijaForm.Guide);
                        ekskurzija.BuildDuration(ekskurzijaForm.Duration);
                        ekskurzija.BuildTransportType(ekskurzijaForm.Transport);
                        af.AddNewPackage(ekskurzija);
                    }

                    break;
                case "Krstarenje":
                    if (activeForm is PaketKrstarenje krstarenjeForm)
                    {
                        var krstarenje = new CruiseArrangementBuilder();
                        if (!double.TryParse(textBox2.Text, out var cena))
                        {
                            MessageBox.Show("Neispravna cena.");
                            return;
                        }
                        krstarenje.BuildCommonDetails(textBox_naziv.Text, cena, "Krstarenje");
                        krstarenje.BuildBoat(krstarenjeForm.Boat);
                        krstarenje.BuildCabinType(krstarenjeForm.Kabina);
                        krstarenje.BuildRoute(krstarenjeForm.Route);
                        krstarenje.BuildDateOfDeparture(krstarenjeForm.DepartureDate);
                        af.AddNewPackage(krstarenje);
                    }

                    break;
                default:
                    return;
            }
        }
    }
}
