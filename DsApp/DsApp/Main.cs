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

namespace Front
{
    // Main.cs
    public partial class Main : Form
    {
        private Form startForm;
        public Main(Form callingForm)
        {
            InitializeComponent();
            startForm = callingForm;
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
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_rezervacije_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());
        }

        private void button_klijenti_Click(object sender, EventArgs e)
        {
            openChildForm(new Klijenti());

            List<Client> clients = new List<Client>();

            AgencyFacade fasada = AgencyFacade.GetInstance();

            clients = fasada.GetAllClients();

            if (activeForm is Klijenti c)
            {
                c.getClientDiv.DataSource = clients;
                if (c.getClientDiv.Columns.Contains("Id"))
                {
                    c.getClientDiv.Columns["Id"].Visible = false;
                }
            }

        }

        private void button_paketi_Click(object sender, EventArgs e)
        {
            openChildForm(new Paketi());
            AgencyFacade fasada = AgencyFacade.GetInstance();
            if (activeForm is Paketi p)
            {
                p.getPaketiDiv.DataSource = fasada.GetAllPackages();
            }
        }

        private void button_izlaz_Click(object sender, EventArgs e)
        {
            
            
            this.Hide();
            startForm.Show();
            //Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }

}
