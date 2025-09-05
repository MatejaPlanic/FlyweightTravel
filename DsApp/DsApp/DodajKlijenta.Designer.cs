namespace Front
{
    partial class DodajKlijenta
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
            label_datum = new Label();
            textBox_prezime = new TextBox();
            textBox_pasos = new TextBox();
            label_ime = new Label();
            label_pasos = new Label();
            textBox_ime = new TextBox();
            label_prezime = new Label();
            panel_top = new Panel();
            dateTimePicker_datum = new DateTimePicker();
            textBox_telefon = new TextBox();
            label_telefon = new Label();
            textBox_mail = new TextBox();
            label_mail = new Label();
            panel_bottom = new Panel();
            button_dodaj_paket = new Button();
            panel_top.SuspendLayout();
            panel_bottom.SuspendLayout();
            SuspendLayout();
            // 
            // label_datum
            // 
            label_datum.AutoSize = true;
            label_datum.Location = new Point(12, 159);
            label_datum.Name = "label_datum";
            label_datum.Size = new Size(108, 16);
            label_datum.TabIndex = 20;
            label_datum.Text = "Datum rođenja:";
            // 
            // textBox_prezime
            // 
            textBox_prezime.BackColor = Color.White;
            textBox_prezime.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_prezime.Location = new Point(15, 77);
            textBox_prezime.Name = "textBox_prezime";
            textBox_prezime.Size = new Size(250, 23);
            textBox_prezime.TabIndex = 17;
            // 
            // textBox_pasos
            // 
            textBox_pasos.BackColor = Color.White;
            textBox_pasos.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_pasos.Location = new Point(15, 128);
            textBox_pasos.Name = "textBox_pasos";
            textBox_pasos.Size = new Size(250, 23);
            textBox_pasos.TabIndex = 19;
            // 
            // label_ime
            // 
            label_ime.AutoSize = true;
            label_ime.Location = new Point(12, 8);
            label_ime.Name = "label_ime";
            label_ime.Size = new Size(35, 16);
            label_ime.TabIndex = 14;
            label_ime.Text = "Ime:";
            // 
            // label_pasos
            // 
            label_pasos.AutoSize = true;
            label_pasos.Location = new Point(12, 111);
            label_pasos.Name = "label_pasos";
            label_pasos.Size = new Size(85, 16);
            label_pasos.TabIndex = 18;
            label_pasos.Text = "Broj Pasoša:";
            // 
            // textBox_ime
            // 
            textBox_ime.BackColor = Color.White;
            textBox_ime.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_ime.Location = new Point(15, 26);
            textBox_ime.Name = "textBox_ime";
            textBox_ime.Size = new Size(250, 23);
            textBox_ime.TabIndex = 15;
            textBox_ime.Tag = "";
            // 
            // label_prezime
            // 
            label_prezime.AutoSize = true;
            label_prezime.Location = new Point(12, 59);
            label_prezime.Name = "label_prezime";
            label_prezime.Size = new Size(61, 16);
            label_prezime.TabIndex = 16;
            label_prezime.Text = "Prezime:";
            // 
            // panel_top
            // 
            panel_top.Controls.Add(dateTimePicker_datum);
            panel_top.Controls.Add(textBox_telefon);
            panel_top.Controls.Add(label_telefon);
            panel_top.Controls.Add(textBox_mail);
            panel_top.Controls.Add(label_mail);
            panel_top.Controls.Add(label_ime);
            panel_top.Controls.Add(label_prezime);
            panel_top.Controls.Add(label_datum);
            panel_top.Controls.Add(textBox_ime);
            panel_top.Controls.Add(textBox_prezime);
            panel_top.Controls.Add(label_pasos);
            panel_top.Controls.Add(textBox_pasos);
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(0, 0);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(334, 309);
            panel_top.TabIndex = 22;
            // 
            // dateTimePicker_datum
            // 
            dateTimePicker_datum.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker_datum.Location = new Point(15, 175);
            dateTimePicker_datum.Name = "dateTimePicker_datum";
            dateTimePicker_datum.Size = new Size(250, 23);
            dateTimePicker_datum.TabIndex = 28;
            // 
            // textBox_telefon
            // 
            textBox_telefon.BackColor = Color.White;
            textBox_telefon.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_telefon.Location = new Point(15, 274);
            textBox_telefon.Name = "textBox_telefon";
            textBox_telefon.Size = new Size(250, 23);
            textBox_telefon.TabIndex = 25;
            // 
            // label_telefon
            // 
            label_telefon.AutoSize = true;
            label_telefon.Location = new Point(12, 256);
            label_telefon.Name = "label_telefon";
            label_telefon.Size = new Size(57, 16);
            label_telefon.TabIndex = 24;
            label_telefon.Text = "Telefon:";
            // 
            // textBox_mail
            // 
            textBox_mail.BackColor = Color.White;
            textBox_mail.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_mail.Location = new Point(15, 227);
            textBox_mail.Name = "textBox_mail";
            textBox_mail.Size = new Size(250, 23);
            textBox_mail.TabIndex = 23;
            // 
            // label_mail
            // 
            label_mail.AutoSize = true;
            label_mail.Location = new Point(12, 209);
            label_mail.Name = "label_mail";
            label_mail.Size = new Size(52, 16);
            label_mail.TabIndex = 22;
            label_mail.Text = "E-mail:";
            // 
            // panel_bottom
            // 
            panel_bottom.Controls.Add(button_dodaj_paket);
            panel_bottom.Dock = DockStyle.Bottom;
            panel_bottom.Location = new Point(0, 388);
            panel_bottom.Name = "panel_bottom";
            panel_bottom.Size = new Size(334, 46);
            panel_bottom.TabIndex = 23;
            // 
            // button_dodaj_paket
            // 
            button_dodaj_paket.Cursor = Cursors.Hand;
            button_dodaj_paket.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_dodaj_paket.ForeColor = Color.FromArgb(0, 71, 160);
            button_dodaj_paket.Location = new Point(94, 3);
            button_dodaj_paket.Name = "button_dodaj_paket";
            button_dodaj_paket.Size = new Size(126, 37);
            button_dodaj_paket.TabIndex = 0;
            button_dodaj_paket.Text = "Dodaj Klijenta";
            button_dodaj_paket.UseVisualStyleBackColor = true;
            // 
            // DodajKlijenta
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 434);
            Controls.Add(panel_bottom);
            Controls.Add(panel_top);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 71, 160);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "DodajKlijenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DodajKlijenta";
            Load += DodajKlijenta_Load;
            panel_top.ResumeLayout(false);
            panel_top.PerformLayout();
            panel_bottom.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_datum;
        private System.Windows.Forms.TextBox textBox_prezime;
        private System.Windows.Forms.TextBox textBox_pasos;
        private System.Windows.Forms.Label label_ime;
        private System.Windows.Forms.Label label_pasos;
        private System.Windows.Forms.TextBox textBox_ime;
        private System.Windows.Forms.Label label_prezime;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.TextBox textBox_telefon;
        private System.Windows.Forms.Label label_telefon;
        private System.Windows.Forms.DateTimePicker dateTimePicker_datum;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Button button_dodaj_paket;
    }
}