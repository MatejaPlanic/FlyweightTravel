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
            panel1 = new Panel();
            panel3 = new Panel();
            button_backup = new Button();
            button_izlaz = new Button();
            button_rezervacije = new Button();
            button_paketi = new Button();
            button_klijenti = new Button();
            label_naziv = new Label();
            panel_main = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label_naziv);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 792);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(button_backup);
            panel3.Controls.Add(button_izlaz);
            panel3.Controls.Add(button_rezervacije);
            panel3.Controls.Add(button_paketi);
            panel3.Controls.Add(button_klijenti);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 99);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(233, 504);
            panel3.TabIndex = 2;
            // 
            // button_backup
            // 
            button_backup.Cursor = Cursors.Hand;
            button_backup.Dock = DockStyle.Top;
            button_backup.FlatAppearance.BorderSize = 0;
            button_backup.FlatStyle = FlatStyle.Flat;
            button_backup.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_backup.ForeColor = Color.White;
            button_backup.Location = new Point(0, 294);
            button_backup.Margin = new Padding(4, 3, 4, 3);
            button_backup.Name = "button_backup";
            button_backup.Padding = new Padding(23, 0, 0, 0);
            button_backup.Size = new Size(233, 98);
            button_backup.TabIndex = 4;
            button_backup.Text = "Sačuvaj bazu";
            button_backup.TextAlign = ContentAlignment.MiddleLeft;
            button_backup.UseVisualStyleBackColor = true;
            button_backup.Click += button_backup_Click;
            // 
            // button_izlaz
            // 
            button_izlaz.Cursor = Cursors.Hand;
            button_izlaz.Dock = DockStyle.Bottom;
            button_izlaz.FlatAppearance.BorderSize = 0;
            button_izlaz.FlatStyle = FlatStyle.Flat;
            button_izlaz.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_izlaz.ForeColor = Color.White;
            button_izlaz.Location = new Point(0, 406);
            button_izlaz.Margin = new Padding(4, 3, 4, 3);
            button_izlaz.Name = "button_izlaz";
            button_izlaz.Padding = new Padding(23, 0, 0, 0);
            button_izlaz.Size = new Size(233, 98);
            button_izlaz.TabIndex = 3;
            button_izlaz.Text = "Izlaz";
            button_izlaz.TextAlign = ContentAlignment.MiddleLeft;
            button_izlaz.UseVisualStyleBackColor = true;
            button_izlaz.Click += button_izlaz_Click;
            // 
            // button_rezervacije
            // 
            button_rezervacije.Cursor = Cursors.Hand;
            button_rezervacije.Dock = DockStyle.Top;
            button_rezervacije.FlatAppearance.BorderSize = 0;
            button_rezervacije.FlatStyle = FlatStyle.Flat;
            button_rezervacije.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_rezervacije.ForeColor = Color.White;
            button_rezervacije.Location = new Point(0, 196);
            button_rezervacije.Margin = new Padding(4, 3, 4, 3);
            button_rezervacije.Name = "button_rezervacije";
            button_rezervacije.Padding = new Padding(23, 0, 0, 0);
            button_rezervacije.Size = new Size(233, 98);
            button_rezervacije.TabIndex = 2;
            button_rezervacije.Text = "Rezervacije";
            button_rezervacije.TextAlign = ContentAlignment.MiddleLeft;
            button_rezervacije.UseVisualStyleBackColor = true;
            button_rezervacije.Click += button_rezervacije_Click;
            // 
            // button_paketi
            // 
            button_paketi.Cursor = Cursors.Hand;
            button_paketi.Dock = DockStyle.Top;
            button_paketi.FlatAppearance.BorderSize = 0;
            button_paketi.FlatStyle = FlatStyle.Flat;
            button_paketi.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_paketi.ForeColor = Color.White;
            button_paketi.Location = new Point(0, 98);
            button_paketi.Margin = new Padding(4, 3, 4, 3);
            button_paketi.Name = "button_paketi";
            button_paketi.Padding = new Padding(23, 0, 0, 0);
            button_paketi.Size = new Size(233, 98);
            button_paketi.TabIndex = 1;
            button_paketi.Text = "Paketi";
            button_paketi.TextAlign = ContentAlignment.MiddleLeft;
            button_paketi.UseVisualStyleBackColor = true;
            button_paketi.Click += button_paketi_Click;
            // 
            // button_klijenti
            // 
            button_klijenti.Cursor = Cursors.Hand;
            button_klijenti.Dock = DockStyle.Top;
            button_klijenti.FlatAppearance.BorderSize = 0;
            button_klijenti.FlatStyle = FlatStyle.Flat;
            button_klijenti.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_klijenti.ForeColor = Color.White;
            button_klijenti.Location = new Point(0, 0);
            button_klijenti.Margin = new Padding(4, 3, 4, 3);
            button_klijenti.Name = "button_klijenti";
            button_klijenti.Padding = new Padding(23, 0, 0, 0);
            button_klijenti.Size = new Size(233, 98);
            button_klijenti.TabIndex = 0;
            button_klijenti.Text = "Klijenti";
            button_klijenti.TextAlign = ContentAlignment.MiddleLeft;
            button_klijenti.UseVisualStyleBackColor = true;
            button_klijenti.Click += button_klijenti_Click;
            // 
            // label_naziv
            // 
            label_naziv.Dock = DockStyle.Top;
            label_naziv.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_naziv.ForeColor = Color.White;
            label_naziv.Location = new Point(0, 0);
            label_naziv.Margin = new Padding(4, 0, 4, 0);
            label_naziv.Name = "label_naziv";
            label_naziv.Size = new Size(233, 99);
            label_naziv.TabIndex = 0;
            label_naziv.Text = "FlyWheitTravel;";
            label_naziv.TextAlign = ContentAlignment.MiddleCenter;
            label_naziv.Click += label_naziv_Click;
            // 
            // panel_main
            // 
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(233, 0);
            panel_main.Margin = new Padding(4, 3, 4, 3);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(1353, 792);
            panel_main.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1586, 792);
            Controls.Add(panel_main);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Turistička agencija";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_naziv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_klijenti;
        private System.Windows.Forms.Button button_rezervacije;
        private System.Windows.Forms.Button button_paketi;
        private System.Windows.Forms.Button button_izlaz;
        private System.Windows.Forms.Panel panel_main;
        private Button button_backup;
    }
}

