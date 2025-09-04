namespace Front
{
    partial class RezervacijaPaketa
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
            textBox2 = new TextBox();
            label_cena = new Label();
            label_naziv = new Label();
            comboBox_tip = new ComboBox();
            label_tip = new Label();
            button_dodaj_rezervaciju = new Button();
            panel_bottom = new Panel();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            panel_bottom.SuspendLayout();
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
            panel1.Size = new Size(334, 276);
            panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(14, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 23);
            textBox2.TabIndex = 11;
            // 
            // label_cena
            // 
            label_cena.AutoSize = true;
            label_cena.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_cena.ForeColor = Color.FromArgb(0, 71, 160);
            label_cena.Location = new Point(11, 139);
            label_cena.Name = "label_cena";
            label_cena.Size = new Size(83, 16);
            label_cena.TabIndex = 10;
            label_cena.Text = "Broj Osoba:";
            // 
            // label_naziv
            // 
            label_naziv.AutoSize = true;
            label_naziv.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_naziv.ForeColor = Color.FromArgb(0, 71, 160);
            label_naziv.Location = new Point(11, 22);
            label_naziv.Name = "label_naziv";
            label_naziv.Size = new Size(84, 16);
            label_naziv.TabIndex = 8;
            label_naziv.Text = "Destinacija:";
            // 
            // comboBox_tip
            // 
            comboBox_tip.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_tip.FormattingEnabled = true;
            comboBox_tip.Location = new Point(14, 103);
            comboBox_tip.Name = "comboBox_tip";
            comboBox_tip.Size = new Size(250, 25);
            comboBox_tip.TabIndex = 7;
            // 
            // label_tip
            // 
            label_tip.AutoSize = true;
            label_tip.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_tip.ForeColor = Color.FromArgb(0, 71, 160);
            label_tip.Location = new Point(11, 84);
            label_tip.Name = "label_tip";
            label_tip.Size = new Size(79, 16);
            label_tip.TabIndex = 6;
            label_tip.Text = "Tip Paketa:";
            label_tip.Click += label_tip_Click;
            // 
            // button_dodaj_rezervaciju
            // 
            button_dodaj_rezervaciju.Cursor = Cursors.Hand;
            button_dodaj_rezervaciju.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_dodaj_rezervaciju.ForeColor = Color.FromArgb(0, 71, 160);
            button_dodaj_rezervaciju.Location = new Point(79, 3);
            button_dodaj_rezervaciju.Name = "button_dodaj_rezervaciju";
            button_dodaj_rezervaciju.Size = new Size(171, 39);
            button_dodaj_rezervaciju.TabIndex = 0;
            button_dodaj_rezervaciju.Text = "Dodaj Rezervaciju";
            button_dodaj_rezervaciju.UseVisualStyleBackColor = true;
            // 
            // panel_bottom
            // 
            panel_bottom.Controls.Add(button_dodaj_rezervaciju);
            panel_bottom.Dock = DockStyle.Bottom;
            panel_bottom.Location = new Point(0, 412);
            panel_bottom.Name = "panel_bottom";
            panel_bottom.Size = new Size(334, 49);
            panel_bottom.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 25);
            comboBox1.TabIndex = 12;
            // 
            // RezervacijaPaketa
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 461);
            Controls.Add(panel_bottom);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "RezervacijaPaketa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RezervacijaPaketa";
            Load += RezervacijaPaketa_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_bottom.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_cena;
        private System.Windows.Forms.Label label_naziv;
        private System.Windows.Forms.ComboBox comboBox_tip;
        private System.Windows.Forms.Label label_tip;
        private System.Windows.Forms.Button button_dodaj_rezervaciju;
        private System.Windows.Forms.Panel panel_bottom;
        private ComboBox comboBox1;
    }
}