namespace Front
{
    partial class PaketEkskurzije
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
            ekskurzija_trajanje = new TextBox();
            label_trajanje = new Label();
            ekskurzija_vodic = new TextBox();
            ekskurzija_prevoz = new TextBox();
            label_destinacija = new Label();
            label_prevoz = new Label();
            ekskurzija_destinacija = new TextBox();
            label_vodic = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ekskurzija_trajanje);
            panel1.Controls.Add(label_trajanje);
            panel1.Controls.Add(ekskurzija_vodic);
            panel1.Controls.Add(ekskurzija_prevoz);
            panel1.Controls.Add(label_destinacija);
            panel1.Controls.Add(label_prevoz);
            panel1.Controls.Add(ekskurzija_destinacija);
            panel1.Controls.Add(label_vodic);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 215);
            panel1.TabIndex = 14;
            // 
            // ekskurzija_trajanje
            // 
            ekskurzija_trajanje.BackColor = Color.White;
            ekskurzija_trajanje.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ekskurzija_trajanje.Location = new Point(12, 190);
            ekskurzija_trajanje.Name = "ekskurzija_trajanje";
            ekskurzija_trajanje.Size = new Size(250, 23);
            ekskurzija_trajanje.TabIndex = 13;
            // 
            // label_trajanje
            // 
            label_trajanje.AutoSize = true;
            label_trajanje.Location = new Point(9, 171);
            label_trajanje.Name = "label_trajanje";
            label_trajanje.Size = new Size(64, 16);
            label_trajanje.TabIndex = 12;
            label_trajanje.Text = "Trajanje:";
            // 
            // ekskurzija_vodic
            // 
            ekskurzija_vodic.BackColor = Color.White;
            ekskurzija_vodic.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ekskurzija_vodic.Location = new Point(12, 84);
            ekskurzija_vodic.Name = "ekskurzija_vodic";
            ekskurzija_vodic.Size = new Size(250, 23);
            ekskurzija_vodic.TabIndex = 9;
            // 
            // ekskurzija_prevoz
            // 
            ekskurzija_prevoz.BackColor = Color.White;
            ekskurzija_prevoz.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ekskurzija_prevoz.Location = new Point(12, 138);
            ekskurzija_prevoz.Name = "ekskurzija_prevoz";
            ekskurzija_prevoz.Size = new Size(250, 23);
            ekskurzija_prevoz.TabIndex = 11;
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
            // ekskurzija_destinacija
            // 
            ekskurzija_destinacija.BackColor = Color.White;
            ekskurzija_destinacija.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ekskurzija_destinacija.Location = new Point(12, 30);
            ekskurzija_destinacija.Name = "ekskurzija_destinacija";
            ekskurzija_destinacija.Size = new Size(250, 23);
            ekskurzija_destinacija.TabIndex = 7;
            // 
            // label_vodic
            // 
            label_vodic.AutoSize = true;
            label_vodic.Location = new Point(9, 65);
            label_vodic.Name = "label_vodic";
            label_vodic.Size = new Size(49, 16);
            label_vodic.TabIndex = 8;
            label_vodic.Text = "Vodič:";
            // 
            // PaketEkskurzije
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 434);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 71, 160);
            Margin = new Padding(4);
            Name = "PaketEkskurzije";
            Text = "PaketEkskurzije";
            Load += PaketEkskurzije_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ekskurzija_trajanje;
        private System.Windows.Forms.Label label_trajanje;
        private System.Windows.Forms.TextBox ekskurzija_vodic;
        private System.Windows.Forms.TextBox ekskurzija_prevoz;
        private System.Windows.Forms.Label label_destinacija;
        private System.Windows.Forms.Label label_prevoz;
        private System.Windows.Forms.TextBox ekskurzija_destinacija;
        private System.Windows.Forms.Label label_vodic;
    }
}