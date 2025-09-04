namespace Front
{
    partial class PaketAranzmanZaPlanine
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
            planina_dodatne = new TextBox();
            label_dodatne_aktivnosti = new Label();
            planina_smestaj = new TextBox();
            planina_prevoz = new TextBox();
            label_destinacija = new Label();
            label_prevoz = new Label();
            planina_destinacija = new TextBox();
            label_smestaj = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(planina_dodatne);
            panel1.Controls.Add(label_dodatne_aktivnosti);
            panel1.Controls.Add(planina_smestaj);
            panel1.Controls.Add(planina_prevoz);
            panel1.Controls.Add(label_destinacija);
            panel1.Controls.Add(label_prevoz);
            panel1.Controls.Add(planina_destinacija);
            panel1.Controls.Add(label_smestaj);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 215);
            panel1.TabIndex = 13;
            // 
            // planina_dodatne
            // 
            planina_dodatne.BackColor = Color.White;
            planina_dodatne.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            planina_dodatne.Location = new Point(12, 190);
            planina_dodatne.Name = "planina_dodatne";
            planina_dodatne.Size = new Size(250, 23);
            planina_dodatne.TabIndex = 13;
            // 
            // label_dodatne_aktivnosti
            // 
            label_dodatne_aktivnosti.AutoSize = true;
            label_dodatne_aktivnosti.Location = new Point(9, 171);
            label_dodatne_aktivnosti.Name = "label_dodatne_aktivnosti";
            label_dodatne_aktivnosti.Size = new Size(133, 16);
            label_dodatne_aktivnosti.TabIndex = 12;
            label_dodatne_aktivnosti.Text = "Dodatne Aktivnosti:";
            // 
            // planina_smestaj
            // 
            planina_smestaj.BackColor = Color.White;
            planina_smestaj.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            planina_smestaj.Location = new Point(12, 84);
            planina_smestaj.Name = "planina_smestaj";
            planina_smestaj.Size = new Size(250, 23);
            planina_smestaj.TabIndex = 9;
            // 
            // planina_prevoz
            // 
            planina_prevoz.BackColor = Color.White;
            planina_prevoz.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            planina_prevoz.Location = new Point(12, 138);
            planina_prevoz.Name = "planina_prevoz";
            planina_prevoz.Size = new Size(250, 23);
            planina_prevoz.TabIndex = 11;
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
            // label_prevoz
            // 
            label_prevoz.AutoSize = true;
            label_prevoz.Location = new Point(9, 120);
            label_prevoz.Name = "label_prevoz";
            label_prevoz.Size = new Size(84, 16);
            label_prevoz.TabIndex = 10;
            label_prevoz.Text = "Tip Prevoza:";
            // 
            // planina_destinacija
            // 
            planina_destinacija.BackColor = Color.White;
            planina_destinacija.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            planina_destinacija.Location = new Point(12, 30);
            planina_destinacija.Name = "planina_destinacija";
            planina_destinacija.Size = new Size(250, 23);
            planina_destinacija.TabIndex = 7;
            planina_destinacija.TextChanged += planina_destinacija_TextChanged;
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
            // PaketAranzmanZaPlanine
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 434);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 71, 160);
            Margin = new Padding(4);
            Name = "PaketAranzmanZaPlanine";
            Text = "PaketAranzmanZaPlanine";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox planina_smestaj;
        private System.Windows.Forms.TextBox planina_prevoz;
        private System.Windows.Forms.Label label_destinacija;
        private System.Windows.Forms.Label label_prevoz;
        private System.Windows.Forms.TextBox planina_destinacija;
        private System.Windows.Forms.Label label_smestaj;
        private System.Windows.Forms.TextBox planina_dodatne;
        private System.Windows.Forms.Label label_dodatne_aktivnosti;
    }
}