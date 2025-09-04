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
            button_dodaj_paket = new Button();
            panel_top = new Panel();
            textBox2 = new TextBox();
            label_cena = new Label();
            textBox_naziv = new TextBox();
            label_naziv = new Label();
            comboBox_tip = new ComboBox();
            label_tip = new Label();
            panel_bottom = new Panel();
            panel_fill = new Panel();
            panel_top.SuspendLayout();
            panel_bottom.SuspendLayout();
            SuspendLayout();
            // 
            // button_dodaj_paket
            // 
            button_dodaj_paket.Cursor = Cursors.Hand;
            button_dodaj_paket.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_dodaj_paket.ForeColor = Color.FromArgb(0, 71, 160);
            button_dodaj_paket.Location = new Point(94, 3);
            button_dodaj_paket.Name = "button_dodaj_paket";
            button_dodaj_paket.Size = new Size(126, 39);
            button_dodaj_paket.TabIndex = 0;
            button_dodaj_paket.Text = "Dodaj Paket";
            button_dodaj_paket.UseVisualStyleBackColor = true;
            // 
            // panel_top
            // 
            panel_top.Controls.Add(textBox2);
            panel_top.Controls.Add(label_cena);
            panel_top.Controls.Add(textBox_naziv);
            panel_top.Controls.Add(label_naziv);
            panel_top.Controls.Add(comboBox_tip);
            panel_top.Controls.Add(label_tip);
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(0, 0);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(334, 177);
            panel_top.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(12, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 23);
            textBox2.TabIndex = 5;
            // 
            // label_cena
            // 
            label_cena.AutoSize = true;
            label_cena.ForeColor = Color.FromArgb(0, 71, 160);
            label_cena.Location = new Point(9, 123);
            label_cena.Name = "label_cena";
            label_cena.Size = new Size(95, 16);
            label_cena.TabIndex = 4;
            label_cena.Text = "Cena Paketa:";
            // 
            // textBox_naziv
            // 
            textBox_naziv.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_naziv.Location = new Point(12, 88);
            textBox_naziv.Name = "textBox_naziv";
            textBox_naziv.Size = new Size(250, 23);
            textBox_naziv.TabIndex = 3;
            // 
            // label_naziv
            // 
            label_naziv.AutoSize = true;
            label_naziv.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_naziv.ForeColor = Color.FromArgb(0, 71, 160);
            label_naziv.Location = new Point(9, 70);
            label_naziv.Name = "label_naziv";
            label_naziv.Size = new Size(96, 16);
            label_naziv.TabIndex = 2;
            label_naziv.Text = "Naziv Paketa:";
            // 
            // comboBox_tip
            // 
            comboBox_tip.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_tip.FormattingEnabled = true;
            comboBox_tip.Location = new Point(12, 28);
            comboBox_tip.Name = "comboBox_tip";
            comboBox_tip.Size = new Size(250, 25);
            comboBox_tip.TabIndex = 1;
            comboBox_tip.SelectedIndexChanged += comboBox_tip_SelectedIndexChanged;
            // 
            // label_tip
            // 
            label_tip.AutoSize = true;
            label_tip.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_tip.ForeColor = Color.FromArgb(0, 71, 160);
            label_tip.Location = new Point(9, 9);
            label_tip.Name = "label_tip";
            label_tip.Size = new Size(79, 16);
            label_tip.TabIndex = 0;
            label_tip.Text = "Tip Paketa:";
            // 
            // panel_bottom
            // 
            panel_bottom.Controls.Add(button_dodaj_paket);
            panel_bottom.Dock = DockStyle.Bottom;
            panel_bottom.Location = new Point(0, 462);
            panel_bottom.Name = "panel_bottom";
            panel_bottom.Size = new Size(334, 49);
            panel_bottom.TabIndex = 2;
            // 
            // panel_fill
            // 
            panel_fill.Dock = DockStyle.Fill;
            panel_fill.Location = new Point(0, 177);
            panel_fill.Name = "panel_fill";
            panel_fill.Size = new Size(334, 285);
            panel_fill.TabIndex = 3;
            // 
            // Novi_Paket
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 511);
            Controls.Add(panel_fill);
            Controls.Add(panel_bottom);
            Controls.Add(panel_top);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "Novi_Paket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novi_Paket";
            Load += Novi_Paket_Load;
            panel_top.ResumeLayout(false);
            panel_top.PerformLayout();
            panel_bottom.ResumeLayout(false);
            ResumeLayout(false);

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