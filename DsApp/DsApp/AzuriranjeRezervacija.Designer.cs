namespace DsApp
{
    partial class AzuriranjeRezervacija
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label_cena = new Label();
            label_naziv = new Label();
            comboBox_tip = new ComboBox();
            label_tip = new Label();
            panel2 = new Panel();
            button_dodaj_rezervaciju = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label_cena);
            panel1.Controls.Add(label_naziv);
            panel1.Controls.Add(comboBox_tip);
            panel1.Controls.Add(label_tip);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 263);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(16, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 25);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(15, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 23);
            textBox2.TabIndex = 17;
            // 
            // label_cena
            // 
            label_cena.AutoSize = true;
            label_cena.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_cena.ForeColor = Color.FromArgb(0, 71, 160);
            label_cena.Location = new Point(12, 126);
            label_cena.Name = "label_cena";
            label_cena.Size = new Size(83, 16);
            label_cena.TabIndex = 16;
            label_cena.Text = "Broj Osoba:";
            // 
            // label_naziv
            // 
            label_naziv.AutoSize = true;
            label_naziv.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_naziv.ForeColor = Color.FromArgb(0, 71, 160);
            label_naziv.Location = new Point(12, 9);
            label_naziv.Name = "label_naziv";
            label_naziv.Size = new Size(84, 16);
            label_naziv.TabIndex = 15;
            label_naziv.Text = "Destinacija:";
            // 
            // comboBox_tip
            // 
            comboBox_tip.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_tip.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_tip.FormattingEnabled = true;
            comboBox_tip.Location = new Point(15, 90);
            comboBox_tip.Name = "comboBox_tip";
            comboBox_tip.Size = new Size(250, 25);
            comboBox_tip.TabIndex = 14;
            // 
            // label_tip
            // 
            label_tip.AutoSize = true;
            label_tip.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_tip.ForeColor = Color.FromArgb(0, 71, 160);
            label_tip.Location = new Point(12, 71);
            label_tip.Name = "label_tip";
            label_tip.Size = new Size(79, 16);
            label_tip.TabIndex = 13;
            label_tip.Text = "Tip Paketa:";
            // 
            // panel2
            // 
            panel2.Controls.Add(button_dodaj_rezervaciju);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 369);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 92);
            panel2.TabIndex = 1;
            // 
            // button_dodaj_rezervaciju
            // 
            button_dodaj_rezervaciju.Cursor = Cursors.Hand;
            button_dodaj_rezervaciju.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_dodaj_rezervaciju.ForeColor = Color.FromArgb(0, 71, 160);
            button_dodaj_rezervaciju.Location = new Point(82, 27);
            button_dodaj_rezervaciju.Name = "button_dodaj_rezervaciju";
            button_dodaj_rezervaciju.Size = new Size(171, 39);
            button_dodaj_rezervaciju.TabIndex = 1;
            button_dodaj_rezervaciju.Text = "Ažuriraj Rezervaciju";
            button_dodaj_rezervaciju.UseVisualStyleBackColor = true;
            // 
            // AzuriranjeRezervacija
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(334, 461);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AzuriranjeRezervacija";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AzuriranjeRezervacija";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label_cena;
        private Label label_naziv;
        private ComboBox comboBox_tip;
        private Label label_tip;
        private Panel panel2;
        private Button button_dodaj_rezervaciju;
    }
}