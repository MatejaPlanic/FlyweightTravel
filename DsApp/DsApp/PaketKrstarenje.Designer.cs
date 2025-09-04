namespace Front
{
    partial class PaketKrstarenje
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
            krstarenje_destinacija = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox_dodatne_aktivnosti = new TextBox();
            label_dodatne_aktivnosti = new Label();
            textBox_ruta = new TextBox();
            label_brod = new Label();
            label_datum = new Label();
            textBox_brod = new TextBox();
            label_ruta = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(krstarenje_destinacija);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox_dodatne_aktivnosti);
            panel1.Controls.Add(label_dodatne_aktivnosti);
            panel1.Controls.Add(textBox_ruta);
            panel1.Controls.Add(label_brod);
            panel1.Controls.Add(label_datum);
            panel1.Controls.Add(textBox_brod);
            panel1.Controls.Add(label_ruta);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 273);
            panel1.TabIndex = 14;
            // 
            // krstarenje_destinacija
            // 
            krstarenje_destinacija.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            krstarenje_destinacija.Location = new Point(12, 30);
            krstarenje_destinacija.Name = "krstarenje_destinacija";
            krstarenje_destinacija.Size = new Size(250, 23);
            krstarenje_destinacija.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 11);
            label1.Name = "label1";
            label1.Size = new Size(84, 16);
            label1.TabIndex = 15;
            label1.Text = "Destinacija:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(12, 191);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // textBox_dodatne_aktivnosti
            // 
            textBox_dodatne_aktivnosti.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_dodatne_aktivnosti.Location = new Point(12, 243);
            textBox_dodatne_aktivnosti.Name = "textBox_dodatne_aktivnosti";
            textBox_dodatne_aktivnosti.Size = new Size(250, 23);
            textBox_dodatne_aktivnosti.TabIndex = 13;
            // 
            // label_dodatne_aktivnosti
            // 
            label_dodatne_aktivnosti.AutoSize = true;
            label_dodatne_aktivnosti.Location = new Point(9, 224);
            label_dodatne_aktivnosti.Name = "label_dodatne_aktivnosti";
            label_dodatne_aktivnosti.Size = new Size(133, 16);
            label_dodatne_aktivnosti.TabIndex = 12;
            label_dodatne_aktivnosti.Text = "Dodatne Aktivnosti:";
            // 
            // textBox_ruta
            // 
            textBox_ruta.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_ruta.Location = new Point(12, 137);
            textBox_ruta.Name = "textBox_ruta";
            textBox_ruta.Size = new Size(250, 23);
            textBox_ruta.TabIndex = 9;
            // 
            // label_brod
            // 
            label_brod.AutoSize = true;
            label_brod.Location = new Point(9, 64);
            label_brod.Name = "label_brod";
            label_brod.Size = new Size(41, 16);
            label_brod.TabIndex = 6;
            label_brod.Text = "Brod:";
            // 
            // label_datum
            // 
            label_datum.AutoSize = true;
            label_datum.Location = new Point(9, 173);
            label_datum.Name = "label_datum";
            label_datum.Size = new Size(108, 16);
            label_datum.TabIndex = 10;
            label_datum.Text = "Datum Polaska:";
            // 
            // textBox_brod
            // 
            textBox_brod.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_brod.Location = new Point(12, 83);
            textBox_brod.Name = "textBox_brod";
            textBox_brod.Size = new Size(250, 23);
            textBox_brod.TabIndex = 7;
            // 
            // label_ruta
            // 
            label_ruta.AutoSize = true;
            label_ruta.Location = new Point(9, 118);
            label_ruta.Name = "label_ruta";
            label_ruta.Size = new Size(40, 16);
            label_ruta.TabIndex = 8;
            label_ruta.Text = "Ruta:";
            // 
            // PaketKrstarenje
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 434);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 71, 160);
            Margin = new Padding(4);
            Name = "PaketKrstarenje";
            Text = "PaketKrstarenje";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_dodatne_aktivnosti;
        private System.Windows.Forms.Label label_dodatne_aktivnosti;
        private System.Windows.Forms.TextBox textBox_ruta;
        private System.Windows.Forms.Label label_brod;
        private System.Windows.Forms.Label label_datum;
        private System.Windows.Forms.TextBox textBox_brod;
        private System.Windows.Forms.Label label_ruta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private TextBox krstarenje_destinacija;
        private Label label1;
    }
}