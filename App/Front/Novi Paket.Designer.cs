namespace Front
{
    partial class Novi_Paket
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
            this.button_dodaj_paket = new System.Windows.Forms.Button();
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel_fill = new System.Windows.Forms.Panel();
            this.label_tip = new System.Windows.Forms.Label();
            this.comboBox_tip = new System.Windows.Forms.ComboBox();
            this.label_naziv = new System.Windows.Forms.Label();
            this.textBox_naziv = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_cena = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_dodaj_paket
            // 
            this.button_dodaj_paket.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dodaj_paket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_dodaj_paket.Location = new System.Drawing.Point(94, 3);
            this.button_dodaj_paket.Name = "button_dodaj_paket";
            this.button_dodaj_paket.Size = new System.Drawing.Size(126, 39);
            this.button_dodaj_paket.TabIndex = 0;
            this.button_dodaj_paket.Text = "Dodaj Paket";
            this.button_dodaj_paket.UseVisualStyleBackColor = true;
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.textBox2);
            this.panel_top.Controls.Add(this.label_cena);
            this.panel_top.Controls.Add(this.textBox_naziv);
            this.panel_top.Controls.Add(this.label_naziv);
            this.panel_top.Controls.Add(this.comboBox_tip);
            this.panel_top.Controls.Add(this.label_tip);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(334, 177);
            this.panel_top.TabIndex = 1;
            // 
            // panel_bottom
            // 
            this.panel_bottom.Controls.Add(this.button_dodaj_paket);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 406);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(334, 49);
            this.panel_bottom.TabIndex = 2;
            // 
            // panel_fill
            // 
            this.panel_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_fill.Location = new System.Drawing.Point(0, 177);
            this.panel_fill.Name = "panel_fill";
            this.panel_fill.Size = new System.Drawing.Size(334, 229);
            this.panel_fill.TabIndex = 3;
            // 
            // label_tip
            // 
            this.label_tip.AutoSize = true;
            this.label_tip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_tip.Location = new System.Drawing.Point(9, 9);
            this.label_tip.Name = "label_tip";
            this.label_tip.Size = new System.Drawing.Size(79, 16);
            this.label_tip.TabIndex = 0;
            this.label_tip.Text = "Tip Paketa:";
            // 
            // comboBox_tip
            // 
            this.comboBox_tip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tip.FormattingEnabled = true;
            this.comboBox_tip.Location = new System.Drawing.Point(12, 28);
            this.comboBox_tip.Name = "comboBox_tip";
            this.comboBox_tip.Size = new System.Drawing.Size(250, 25);
            this.comboBox_tip.TabIndex = 1;
            this.comboBox_tip.SelectedIndexChanged += new System.EventHandler(this.comboBox_tip_SelectedIndexChanged);
            // 
            // label_naziv
            // 
            this.label_naziv.AutoSize = true;
            this.label_naziv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_naziv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_naziv.Location = new System.Drawing.Point(9, 70);
            this.label_naziv.Name = "label_naziv";
            this.label_naziv.Size = new System.Drawing.Size(96, 16);
            this.label_naziv.TabIndex = 2;
            this.label_naziv.Text = "Naziv Paketa:";
            // 
            // textBox_naziv
            // 
            this.textBox_naziv.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_naziv.Location = new System.Drawing.Point(12, 88);
            this.textBox_naziv.Name = "textBox_naziv";
            this.textBox_naziv.Size = new System.Drawing.Size(250, 23);
            this.textBox_naziv.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 23);
            this.textBox2.TabIndex = 5;
            // 
            // label_cena
            // 
            this.label_cena.AutoSize = true;
            this.label_cena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_cena.Location = new System.Drawing.Point(9, 123);
            this.label_cena.Name = "label_cena";
            this.label_cena.Size = new System.Drawing.Size(95, 16);
            this.label_cena.TabIndex = 4;
            this.label_cena.Text = "Cena Paketa:";
            // 
            // Novi_Paket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 455);
            this.Controls.Add(this.panel_fill);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Novi_Paket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi_Paket";
            this.Load += new System.EventHandler(this.Novi_Paket_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_dodaj_paket;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.ComboBox comboBox_tip;
        private System.Windows.Forms.Label label_tip;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Panel panel_fill;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_cena;
        private System.Windows.Forms.TextBox textBox_naziv;
        private System.Windows.Forms.Label label_naziv;
    }
}