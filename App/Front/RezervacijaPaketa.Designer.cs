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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_cena = new System.Windows.Forms.Label();
            this.textBox_naziv = new System.Windows.Forms.TextBox();
            this.label_naziv = new System.Windows.Forms.Label();
            this.comboBox_tip = new System.Windows.Forms.ComboBox();
            this.label_tip = new System.Windows.Forms.Label();
            this.button_dodaj_rezervaciju = new System.Windows.Forms.Button();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label_cena);
            this.panel1.Controls.Add(this.textBox_naziv);
            this.panel1.Controls.Add(this.label_naziv);
            this.panel1.Controls.Add(this.comboBox_tip);
            this.panel1.Controls.Add(this.label_tip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 276);
            this.panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(15, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 23);
            this.textBox2.TabIndex = 11;
            // 
            // label_cena
            // 
            this.label_cena.AutoSize = true;
            this.label_cena.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_cena.Location = new System.Drawing.Point(12, 9);
            this.label_cena.Name = "label_cena";
            this.label_cena.Size = new System.Drawing.Size(83, 16);
            this.label_cena.TabIndex = 10;
            this.label_cena.Text = "Broj Osoba:";
            // 
            // textBox_naziv
            // 
            this.textBox_naziv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_naziv.Location = new System.Drawing.Point(15, 88);
            this.textBox_naziv.Name = "textBox_naziv";
            this.textBox_naziv.Size = new System.Drawing.Size(250, 23);
            this.textBox_naziv.TabIndex = 9;
            // 
            // label_naziv
            // 
            this.label_naziv.AutoSize = true;
            this.label_naziv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_naziv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_naziv.Location = new System.Drawing.Point(12, 70);
            this.label_naziv.Name = "label_naziv";
            this.label_naziv.Size = new System.Drawing.Size(84, 16);
            this.label_naziv.TabIndex = 8;
            this.label_naziv.Text = "Destinacija:";
            // 
            // comboBox_tip
            // 
            this.comboBox_tip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tip.FormattingEnabled = true;
            this.comboBox_tip.Location = new System.Drawing.Point(15, 145);
            this.comboBox_tip.Name = "comboBox_tip";
            this.comboBox_tip.Size = new System.Drawing.Size(250, 25);
            this.comboBox_tip.TabIndex = 7;
            // 
            // label_tip
            // 
            this.label_tip.AutoSize = true;
            this.label_tip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_tip.Location = new System.Drawing.Point(12, 126);
            this.label_tip.Name = "label_tip";
            this.label_tip.Size = new System.Drawing.Size(79, 16);
            this.label_tip.TabIndex = 6;
            this.label_tip.Text = "Tip Paketa:";
            this.label_tip.Click += new System.EventHandler(this.label_tip_Click);
            // 
            // button_dodaj_rezervaciju
            // 
            this.button_dodaj_rezervaciju.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dodaj_rezervaciju.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_dodaj_rezervaciju.Location = new System.Drawing.Point(79, 3);
            this.button_dodaj_rezervaciju.Name = "button_dodaj_rezervaciju";
            this.button_dodaj_rezervaciju.Size = new System.Drawing.Size(171, 39);
            this.button_dodaj_rezervaciju.TabIndex = 0;
            this.button_dodaj_rezervaciju.Text = "Dodaj Rezervaciju";
            this.button_dodaj_rezervaciju.UseVisualStyleBackColor = true;
            // 
            // panel_bottom
            // 
            this.panel_bottom.Controls.Add(this.button_dodaj_rezervaciju);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 412);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(334, 49);
            this.panel_bottom.TabIndex = 3;
            // 
            // RezervacijaPaketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RezervacijaPaketa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RezervacijaPaketa";
            this.Load += new System.EventHandler(this.RezervacijaPaketa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_cena;
        private System.Windows.Forms.TextBox textBox_naziv;
        private System.Windows.Forms.Label label_naziv;
        private System.Windows.Forms.ComboBox comboBox_tip;
        private System.Windows.Forms.Label label_tip;
        private System.Windows.Forms.Button button_dodaj_rezervaciju;
        private System.Windows.Forms.Panel panel_bottom;
    }
}