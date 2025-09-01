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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            comboBox_file.Items.Add("file1.txt");
            comboBox_file.Items.Add("file2.txt");
            comboBox_file.SelectedIndex = 0; // Postavljanje default selektovane stavke
        }

        private void comboBox_file_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.Show();
        }
    }
}
