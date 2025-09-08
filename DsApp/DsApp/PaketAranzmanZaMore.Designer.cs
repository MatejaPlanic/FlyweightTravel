namespace Front
{
    partial class PaketAranzmanZaMore
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
            more_smestaj = new TextBox();
            label_smestaj = new Label();
            more_destinacija = new TextBox();
            label_destinacija = new Label();
            more_prevoz = new TextBox();
            label_prevoz = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // more_smestaj
            // 
            more_smestaj.BackColor = Color.White;
            more_smestaj.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            more_smestaj.Location = new Point(12, 84);
            more_smestaj.Name = "more_smestaj";
            more_smestaj.Size = new Size(250, 23);
            more_smestaj.TabIndex = 9;
            // 
            // label_smestaj
            // 
            label_smestaj.AutoSize = true;
            label_smestaj.Location = new Point(9, 65);
            label_smestaj.Name = "label_smestaj";
            label_smestaj.Size = new Size(107, 16);
            label_smestaj.TabIndex = 8;
            label_smestaj.Text = "Vrsta Smeštaja:";
            // 
            // more_destinacija
            // 
            more_destinacija.BackColor = Color.White;
            more_destinacija.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            more_destinacija.Location = new Point(12, 30);
            more_destinacija.Name = "more_destinacija";
            more_destinacija.Size = new Size(250, 23);
            more_destinacija.TabIndex = 7;
            // 
            // label_destinacija
            // 
            label_destinacija.AutoSize = true;
            label_destinacija.Location = new Point(9, 11);
            label_destinacija.Name = "label_destinacija";
            label_destinacija.Size = new Size(84, 16);
            label_destinacija.TabIndex = 6;
            label_destinacija.Text = "Destinacija:";
            // 
            // more_prevoz
            // 
            more_prevoz.BackColor = Color.White;
            more_prevoz.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            more_prevoz.Location = new Point(12, 138);
            more_prevoz.Name = "more_prevoz";
            more_prevoz.Size = new Size(250, 23);
            more_prevoz.TabIndex = 11;
            // 
            // label_prevoz
            // 
            label_prevoz.AutoSize = true;
            label_prevoz.Location = new Point(9, 120);
            label_prevoz.Name = "label_prevoz";
            label_prevoz.Size = new Size(84, 16);
            label_prevoz.TabIndex = 10;
            label_prevoz.Text = "Tip Prevoza:";
            // 
            // panel1
            // 
            panel1.Controls.Add(more_smestaj);
            panel1.Controls.Add(more_prevoz);
            panel1.Controls.Add(label_destinacija);
            panel1.Controls.Add(label_prevoz);
            panel1.Controls.Add(more_destinacija);
            panel1.Controls.Add(label_smestaj);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 183);
            panel1.TabIndex = 12;
            // 
            // PaketAranzmanZaMore
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 434);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 71, 160);
            Margin = new Padding(4);
            Name = "PaketAranzmanZaMore";
            Text = "PaketAranzmanZaMore";
            Load += PaketAranzmanZaMore_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox more_smestaj;
        private System.Windows.Forms.Label label_smestaj;
        private System.Windows.Forms.TextBox more_destinacija;
        private System.Windows.Forms.Label label_destinacija;
        private System.Windows.Forms.TextBox more_prevoz;
        private System.Windows.Forms.Label label_prevoz;
        private System.Windows.Forms.Panel panel1;
    }
}