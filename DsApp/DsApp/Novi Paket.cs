using DsApp.Builders;
using DsApp.Facade;
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
            if (comboBox_tip.SelectedItem == null)
            {
                MessageBox.Show("Odaberite tip paketa.");
                return;
            }
            if(textBox_naziv.Text == "")
            {
                MessageBox.Show("Unesite naziv paketa.");
                return;
            }
            if(textBox2.Text == "")
            {
                MessageBox.Show("Unesite cenu paketa.");
                return;
            }

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
                        if(moreForm.DestinationText == "")
                        {
                            MessageBox.Show("Unesite destinaciju.");
                            return;
                        }
                        sea.BuildDestination(moreForm.DestinationText);
                        if (moreForm.AccommodationText == "")
                        {
                            MessageBox.Show("Unesite tip smestaja.");
                            return;
                        }
                        sea.BuildAccommodationType(moreForm.AccommodationText);
                        if (moreForm.TransportText == "")
                        {
                            MessageBox.Show("Unesite tip prevoza.");
                            return;
                        }
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
                        if (planineForm.Destination == "")
                        {
                            MessageBox.Show("Unesite destinaciju.");
                            return;
                        }
                        planina.BuildDestination(planineForm.Destination);
                        if (planineForm.Accommodation == "")
                        {
                            MessageBox.Show("Unesite tip smestaj.");
                            return;
                        }
                        planina.BuildAccommodationType(planineForm.Accommodation);

                       
                        if (planineForm.Transport == "")
                        {
                            MessageBox.Show("Unesite tip prevoza.");
                            return;
                        }
                        planina.BuildTransportType(planineForm.Transport);
                       
                        if (planineForm.Dodatne == "")
                        {
                            MessageBox.Show("Unesite dodatne aktivnosti.");
                            return;
                        }
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
                        if (ekskurzijaForm.Destination == "")
                        {
                            MessageBox.Show("Unesite destinaciju.");
                            return;
                        }
                        ekskurzija.BuildDestination(ekskurzijaForm.Destination);
                        if (ekskurzijaForm.Guide == "")
                        {
                            MessageBox.Show("Unesite vodiča.");
                            return;
                        }
                        ekskurzija.BuildGuide(ekskurzijaForm.Guide);
                        if (ekskurzijaForm.Transport == "")
                        {
                            MessageBox.Show("Unesite tip prevoza.");
                            return;
                        }
                        ekskurzija.BuildTransportType(ekskurzijaForm.Transport);
                        if (ekskurzijaForm.Duration == "")
                        {
                            MessageBox.Show("Unesite trajanje.");
                            return;
                        }
                        ekskurzija.BuildDuration(ekskurzijaForm.Duration);
                        
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
                        if (krstarenjeForm.Destination == "")
                        {
                            MessageBox.Show("Unesite destinaciju.");
                            return;
                        }
                        krstarenje.BuildDestination(krstarenjeForm.Destination);
                        if (krstarenjeForm.Boat == "")
                        {
                            MessageBox.Show("Unesite brod.");
                            return;
                        }
                        krstarenje.BuildBoat(krstarenjeForm.Boat);
                        if (!DateTime.TryParseExact(
                            krstarenjeForm.DepartureDate,
                            "yyyy-MM-dd",
                            CultureInfo.InvariantCulture,
                            DateTimeStyles.None,
                            out var depDate))
                        {
                            MessageBox.Show("Neispravan format datuma (očekujem yyyy-MM-dd).");
                            return;
                        }

                        if (depDate.Date <= DateTime.Today)
                        {
                            MessageBox.Show("Datum polaska mora biti posle današnjeg datuma.");
                            return;
                        }
                        krstarenje.BuildDateOfDeparture(krstarenjeForm.DepartureDate);
                        if (krstarenjeForm.Boat == "")
                        {
                            MessageBox.Show("Unesite tip kabine.");
                            return;
                        }
                        krstarenje.BuildCabinType(krstarenjeForm.Kabina);
                        if (krstarenjeForm.Route == "")
                        {
                            MessageBox.Show("Unesite tip rute.");
                            return;
                        }
                        krstarenje.BuildRoute(krstarenjeForm.Route);
                        
                        
                        af.AddNewPackage(krstarenje);
                    }

                    break;
                default:
                    return;
            }
            MessageBox.Show("Uspesno ste dodali paket");
            this.Close();
        }
    }
}
