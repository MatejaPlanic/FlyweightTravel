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
            krstarenje_datum = new DateTimePicker();
            krstarenje_kabina = new TextBox();
            label_dodatne_aktivnosti = new Label();
            krstarenje_ruta = new TextBox();
            label_brod = new Label();
            label_datum = new Label();
            krstarenje_brod = new TextBox();
            label_ruta = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(krstarenje_datum);
            panel1.Controls.Add(krstarenje_kabina);
            panel1.Controls.Add(label_dodatne_aktivnosti);
            panel1.Controls.Add(krstarenje_ruta);
            panel1.Controls.Add(label_brod);
            panel1.Controls.Add(label_datum);
            panel1.Controls.Add(krstarenje_brod);
            panel1.Controls.Add(label_ruta);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 215);
            panel1.TabIndex = 14;
            // 
            // krstarenje_datum
            // 
            krstarenje_datum.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            krstarenje_datum.Location = new Point(12, 138);
            krstarenje_datum.Name = "krstarenje_datum";
            krstarenje_datum.Size = new Size(250, 23);
            krstarenje_datum.TabIndex = 14;
            // 
            // krstarenje_kabina
            // 
            krstarenje_kabina.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            krstarenje_kabina.Location = new Point(12, 190);
            krstarenje_kabina.Name = "krstarenje_kabina";
            krstarenje_kabina.Size = new Size(250, 23);
            krstarenje_kabina.TabIndex = 13;
            // 
            // label_dodatne_aktivnosti
            // 
            label_dodatne_aktivnosti.AutoSize = true;
            label_dodatne_aktivnosti.Location = new Point(9, 171);
            label_dodatne_aktivnosti.Name = "label_dodatne_aktivnosti";
            label_dodatne_aktivnosti.Size = new Size(80, 16);
            label_dodatne_aktivnosti.TabIndex = 12;
            label_dodatne_aktivnosti.Text = "Tip Kabine:";
            label_dodatne_aktivnosti.Click += label_dodatne_aktivnosti_Click;
            // 
            // krstarenje_ruta
            // 
            krstarenje_ruta.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            krstarenje_ruta.Location = new Point(12, 84);
            krstarenje_ruta.Name = "krstarenje_ruta";
            krstarenje_ruta.Size = new Size(250, 23);
            krstarenje_ruta.TabIndex = 9;
            // 
            // label_brod
            // 
            label_brod.AutoSize = true;
            label_brod.Location = new Point(9, 11);
            label_brod.Name = "label_brod";
            label_brod.Size = new Size(41, 16);
            label_brod.TabIndex = 6;
            label_brod.Text = "Brod:";
            // 
            // label_datum
            // 
            label_datum.AutoSize = true;
            label_datum.Location = new Point(9, 120);
            label_datum.Name = "label_datum";
            label_datum.Size = new Size(108, 16);
            label_datum.TabIndex = 10;
            label_datum.Text = "Datum Polaska:";
            // 
            // krstarenje_brod
            // 
            krstarenje_brod.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            krstarenje_brod.Location = new Point(12, 30);
            krstarenje_brod.Name = "krstarenje_brod";
            krstarenje_brod.Size = new Size(250, 23);
            krstarenje_brod.TabIndex = 7;
            // 
            // label_ruta
            // 
            label_ruta.AutoSize = true;
            label_ruta.Location = new Point(9, 65);
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
        private System.Windows.Forms.TextBox krstarenje_kabina;
        private System.Windows.Forms.Label label_dodatne_aktivnosti;
        private System.Windows.Forms.TextBox krstarenje_ruta;
        private System.Windows.Forms.Label label_brod;
        private System.Windows.Forms.Label label_datum;
        private System.Windows.Forms.TextBox krstarenje_brod;
        private System.Windows.Forms.Label label_ruta;
        private System.Windows.Forms.DateTimePicker krstarenje_datum;
    }
}