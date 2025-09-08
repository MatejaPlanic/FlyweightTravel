namespace Front
{
    partial class Klijenti
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label5 = new Label();
            div_clients = new Guna.UI2.WinForms.Guna2DataGridView();
            button_pretraga = new Button();
            textBox_pretraga = new TextBox();
            button_dodaj = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)div_clients).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            label5.Location = new Point(434, 14);
            label5.Name = "label5";
            label5.Size = new Size(71, 23);
            label5.TabIndex = 0;
            label5.Text = "Klijenti";
            label5.Click += label5_Click;
            // 
            // div_clients
            // 
            dataGridViewCellStyle7.BackColor = Color.White;
            div_clients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            div_clients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            div_clients.BackgroundColor = Color.Gainsboro;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            div_clients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            div_clients.ColumnHeadersHeight = 40;
            div_clients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            div_clients.DefaultCellStyle = dataGridViewCellStyle9;
            div_clients.GridColor = Color.FromArgb(231, 229, 255);
            div_clients.Location = new Point(0, 0);
            div_clients.Name = "div_clients";
            div_clients.RowHeadersVisible = false;
            div_clients.RowTemplate.Height = 22;
            div_clients.Size = new Size(934, 445);
            div_clients.TabIndex = 19;
            div_clients.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            div_clients.ThemeStyle.AlternatingRowsStyle.Font = null;
            div_clients.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            div_clients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            div_clients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            div_clients.ThemeStyle.BackColor = Color.Gainsboro;
            div_clients.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            div_clients.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            div_clients.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            div_clients.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            div_clients.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            div_clients.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            div_clients.ThemeStyle.HeaderStyle.Height = 40;
            div_clients.ThemeStyle.ReadOnly = false;
            div_clients.ThemeStyle.RowsStyle.BackColor = Color.White;
            div_clients.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            div_clients.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            div_clients.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            div_clients.ThemeStyle.RowsStyle.Height = 22;
            div_clients.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            div_clients.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // button_pretraga
            // 
            button_pretraga.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_pretraga.BackColor = Color.Orange;
            button_pretraga.Cursor = Cursors.Hand;
            button_pretraga.FlatStyle = FlatStyle.Flat;
            button_pretraga.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_pretraga.ForeColor = Color.White;
            button_pretraga.Location = new Point(811, 63);
            button_pretraga.Name = "button_pretraga";
            button_pretraga.Size = new Size(111, 39);
            button_pretraga.TabIndex = 29;
            button_pretraga.Text = "Pretraži";
            button_pretraga.UseVisualStyleBackColor = false;
            button_pretraga.Click += button1_Click;
            // 
            // textBox_pretraga
            // 
            textBox_pretraga.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox_pretraga.BorderStyle = BorderStyle.FixedSingle;
            textBox_pretraga.Location = new Point(512, 70);
            textBox_pretraga.Name = "textBox_pretraga";
            textBox_pretraga.Size = new Size(293, 27);
            textBox_pretraga.TabIndex = 30;
            textBox_pretraga.TextChanged += textBox_pretraga_TextChanged;
            // 
            // button_dodaj
            // 
            button_dodaj.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_dodaj.BackColor = Color.Green;
            button_dodaj.Cursor = Cursors.Hand;
            button_dodaj.FlatStyle = FlatStyle.Flat;
            button_dodaj.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_dodaj.ForeColor = Color.White;
            button_dodaj.Location = new Point(811, 18);
            button_dodaj.Name = "button_dodaj";
            button_dodaj.Size = new Size(111, 39);
            button_dodaj.TabIndex = 32;
            button_dodaj.Text = "Dodaj";
            button_dodaj.UseVisualStyleBackColor = false;
            button_dodaj.Click += button_dodaj_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button_dodaj);
            panel2.Controls.Add(button_pretraga);
            panel2.Controls.Add(textBox_pretraga);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 500);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 111);
            panel2.TabIndex = 33;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(div_clients);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 55);
            panel3.Name = "panel3";
            panel3.Size = new Size(934, 445);
            panel3.TabIndex = 34;
            // 
            // Klijenti
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 611);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Klijenti";
            Text = "Klijenti";
            Load += Klijenti_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)div_clients).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView div_clients;
        private System.Windows.Forms.Button button_pretraga;
        private System.Windows.Forms.TextBox textBox_pretraga;
        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
