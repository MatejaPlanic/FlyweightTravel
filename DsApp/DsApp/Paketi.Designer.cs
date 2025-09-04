namespace Front
{
    partial class Paketi
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label5 = new Label();
            div_paketi = new Guna.UI2.WinForms.Guna2DataGridView();
            panel_info = new Panel();
            button_dodaj = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)div_paketi).BeginInit();
            panel_info.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 55);
            panel1.TabIndex = 17;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(422, 16);
            label5.Name = "label5";
            label5.Size = new Size(68, 23);
            label5.TabIndex = 0;
            label5.Text = "Paketi";
            // 
            // div_paketi
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            div_paketi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            div_paketi.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            div_paketi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            div_paketi.ColumnHeadersHeight = 40;
            div_paketi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            div_paketi.DefaultCellStyle = dataGridViewCellStyle6;
            div_paketi.Dock = DockStyle.Fill;
            div_paketi.GridColor = Color.FromArgb(231, 229, 255);
            div_paketi.Location = new Point(0, 55);
            div_paketi.Name = "div_paketi";
            div_paketi.RowHeadersVisible = false;
            div_paketi.RowTemplate.Height = 22;
            div_paketi.Size = new Size(934, 556);
            div_paketi.TabIndex = 18;
            div_paketi.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            div_paketi.ThemeStyle.AlternatingRowsStyle.Font = null;
            div_paketi.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            div_paketi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            div_paketi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            div_paketi.ThemeStyle.BackColor = Color.Gainsboro;
            div_paketi.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            div_paketi.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            div_paketi.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            div_paketi.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            div_paketi.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            div_paketi.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            div_paketi.ThemeStyle.HeaderStyle.Height = 40;
            div_paketi.ThemeStyle.ReadOnly = false;
            div_paketi.ThemeStyle.RowsStyle.BackColor = Color.White;
            div_paketi.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            div_paketi.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            div_paketi.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            div_paketi.ThemeStyle.RowsStyle.Height = 22;
            div_paketi.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            div_paketi.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // panel_info
            // 
            panel_info.Controls.Add(button_dodaj);
            panel_info.Dock = DockStyle.Bottom;
            panel_info.Location = new Point(0, 518);
            panel_info.Name = "panel_info";
            panel_info.Size = new Size(934, 93);
            panel_info.TabIndex = 19;
            // 
            // button_dodaj
            // 
            button_dodaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_dodaj.BackColor = Color.FromArgb(0, 160, 31);
            button_dodaj.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_dodaj.ForeColor = Color.White;
            button_dodaj.Location = new Point(788, 37);
            button_dodaj.Name = "button_dodaj";
            button_dodaj.Size = new Size(134, 44);
            button_dodaj.TabIndex = 28;
            button_dodaj.Text = "Dodaj Paket";
            button_dodaj.UseVisualStyleBackColor = false;
            button_dodaj.Click += button_dodaj_Click;
            // 
            // Paketi
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 611);
            Controls.Add(panel_info);
            Controls.Add(div_paketi);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Paketi";
            Text = "Paketi";
            Load += Paketi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)div_paketi).EndInit();
            panel_info.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView div_paketi;
        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.Button button_dodaj;
    }
}