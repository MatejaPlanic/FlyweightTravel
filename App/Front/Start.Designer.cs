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
            this.comboBox_file = new System.Windows.Forms.ComboBox();
            this.button_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_file
            // 
            this.comboBox_file.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_file.FormattingEnabled = true;
            this.comboBox_file.Location = new System.Drawing.Point(121, 153);
            this.comboBox_file.Name = "comboBox_file";
            this.comboBox_file.Size = new System.Drawing.Size(121, 29);
            this.comboBox_file.TabIndex = 0;
            this.comboBox_file.SelectedIndexChanged += new System.EventHandler(this.comboBox_file_SelectedIndexChanged);
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(140, 316);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(90, 44);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.comboBox_file);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_file;
        private System.Windows.Forms.Button button_start;
    }
}