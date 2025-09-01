namespace Front
{
    partial class Main
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_izlaz = new System.Windows.Forms.Button();
            this.button_dodavanje_klijenta = new System.Windows.Forms.Button();
            this.button_paketi = new System.Windows.Forms.Button();
            this.button_klijenti = new System.Windows.Forms.Button();
            this.label_naziv = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label_naziv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 617);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_izlaz);
            this.panel3.Controls.Add(this.button_dodavanje_klijenta);
            this.panel3.Controls.Add(this.button_paketi);
            this.panel3.Controls.Add(this.button_klijenti);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 385);
            this.panel3.TabIndex = 2;
            // 
            // button_izlaz
            // 
            this.button_izlaz.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_izlaz.FlatAppearance.BorderSize = 0;
            this.button_izlaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_izlaz.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_izlaz.ForeColor = System.Drawing.Color.White;
            this.button_izlaz.Location = new System.Drawing.Point(0, 255);
            this.button_izlaz.Name = "button_izlaz";
            this.button_izlaz.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_izlaz.Size = new System.Drawing.Size(200, 85);
            this.button_izlaz.TabIndex = 3;
            this.button_izlaz.Text = "Izlaz";
            this.button_izlaz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_izlaz.UseVisualStyleBackColor = true;
            this.button_izlaz.Click += new System.EventHandler(this.button_izlaz_Click);
            // 
            // button_dodavanje_klijenta
            // 
            this.button_dodavanje_klijenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_dodavanje_klijenta.FlatAppearance.BorderSize = 0;
            this.button_dodavanje_klijenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dodavanje_klijenta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dodavanje_klijenta.ForeColor = System.Drawing.Color.White;
            this.button_dodavanje_klijenta.Location = new System.Drawing.Point(0, 170);
            this.button_dodavanje_klijenta.Name = "button_dodavanje_klijenta";
            this.button_dodavanje_klijenta.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_dodavanje_klijenta.Size = new System.Drawing.Size(200, 85);
            this.button_dodavanje_klijenta.TabIndex = 2;
            this.button_dodavanje_klijenta.Text = "Novi Klijent";
            this.button_dodavanje_klijenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dodavanje_klijenta.UseVisualStyleBackColor = true;
            this.button_dodavanje_klijenta.Click += new System.EventHandler(this.button_dodavanje_klijenta_Click);
            // 
            // button_paketi
            // 
            this.button_paketi.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_paketi.FlatAppearance.BorderSize = 0;
            this.button_paketi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_paketi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_paketi.ForeColor = System.Drawing.Color.White;
            this.button_paketi.Location = new System.Drawing.Point(0, 85);
            this.button_paketi.Name = "button_paketi";
            this.button_paketi.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_paketi.Size = new System.Drawing.Size(200, 85);
            this.button_paketi.TabIndex = 1;
            this.button_paketi.Text = "Paketi";
            this.button_paketi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_paketi.UseVisualStyleBackColor = true;
            this.button_paketi.Click += new System.EventHandler(this.button_paketi_Click);
            // 
            // button_klijenti
            // 
            this.button_klijenti.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_klijenti.FlatAppearance.BorderSize = 0;
            this.button_klijenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_klijenti.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_klijenti.ForeColor = System.Drawing.Color.White;
            this.button_klijenti.Location = new System.Drawing.Point(0, 0);
            this.button_klijenti.Name = "button_klijenti";
            this.button_klijenti.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_klijenti.Size = new System.Drawing.Size(200, 85);
            this.button_klijenti.TabIndex = 0;
            this.button_klijenti.Text = "Klijenti";
            this.button_klijenti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_klijenti.UseVisualStyleBackColor = true;
            this.button_klijenti.Click += new System.EventHandler(this.button_klijenti_Click);
            // 
            // label_naziv
            // 
            this.label_naziv.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_naziv.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_naziv.ForeColor = System.Drawing.Color.White;
            this.label_naziv.Location = new System.Drawing.Point(0, 0);
            this.label_naziv.Name = "label_naziv";
            this.label_naziv.Size = new System.Drawing.Size(200, 86);
            this.label_naziv.TabIndex = 0;
            this.label_naziv.Text = "FlyWheitTravel;";
            this.label_naziv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_main
            // 
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(200, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(934, 617);
            this.panel_main.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 617);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turistička agencija";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_naziv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_klijenti;
        private System.Windows.Forms.Button button_dodavanje_klijenta;
        private System.Windows.Forms.Button button_paketi;
        private System.Windows.Forms.Button button_izlaz;
        private System.Windows.Forms.Panel panel_main;
    }
}

