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
        public Main()
        {
            InitializeComponent();
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

        private void button_dodavanje_klijenta_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());
        }

        private void button_klijenti_Click(object sender, EventArgs e)
        {
            openChildForm(new Klijenti());
        }

        private void button_paketi_Click(object sender, EventArgs e)
        {
            openChildForm(new Paketi());
        }

        private void button_izlaz_Click(object sender, EventArgs e)
        {
            //Start start=new Start();
            //this.Hide();
            //start.Show();
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }

}
