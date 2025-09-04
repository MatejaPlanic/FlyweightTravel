namespace Front
{
    partial class Start
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
            comboBox_file = new ComboBox();
            button_start = new Button();
            label = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox_file
            // 
            comboBox_file.Anchor = AnchorStyles.None;
            comboBox_file.Cursor = Cursors.Hand;
            comboBox_file.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_file.FormattingEnabled = true;
            comboBox_file.Location = new Point(63, 74);
            comboBox_file.Margin = new Padding(4, 3, 4, 3);
            comboBox_file.Name = "comboBox_file";
            comboBox_file.Size = new Size(292, 29);
            comboBox_file.TabIndex = 0;
            comboBox_file.SelectedIndexChanged += comboBox_file_SelectedIndexChanged;
            // 
            // button_start
            // 
            button_start.Anchor = AnchorStyles.None;
            button_start.BackColor = Color.FromArgb(0, 71, 160);
            button_start.Cursor = Cursors.Hand;
            button_start.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_start.ForeColor = Color.White;
            button_start.Location = new Point(63, 37);
            button_start.Margin = new Padding(4, 3, 4, 3);
            button_start.Name = "button_start";
            button_start.Size = new Size(293, 51);
            button_start.TabIndex = 1;
            button_start.Text = "Start";
            button_start.UseVisualStyleBackColor = false;
            button_start.Click += button_start_Click;
            // 
            // label
            // 
            label.Anchor = AnchorStyles.None;
            label.AutoSize = true;
            label.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = Color.FromArgb(0, 71, 160);
            label.Location = new Point(104, 31);
            label.Margin = new Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new Size(185, 23);
            label.TabIndex = 2;
            label.Text = "Turistička Agencija";
            // 
            // panel1
            // 
            panel1.Controls.Add(label);
            panel1.Controls.Add(comboBox_file);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 144);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(button_start);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 143);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(433, 133);
            panel2.TabIndex = 4;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(433, 276);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Start";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dobrodošli";
            Load += Start_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_file;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}