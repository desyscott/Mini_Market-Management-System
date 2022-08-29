namespace Mini_Market_Management_System
{
    partial class BarCodeScanner
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
            this.components = new System.ComponentModel.Container();
            this.button_scan = new Guna.UI2.WinForms.Guna2GradientButton();
            this.textBox_display = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.display = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_camera = new System.Windows.Forms.ComboBox();
            this.barcode_exit = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button_scan
            // 
            this.button_scan.BorderRadius = 2;
            this.button_scan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_scan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_scan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_scan.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_scan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_scan.FillColor = System.Drawing.Color.SlateGray;
            this.button_scan.FillColor2 = System.Drawing.Color.LightSteelBlue;
            this.button_scan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_scan.ForeColor = System.Drawing.Color.White;
            this.button_scan.Location = new System.Drawing.Point(74, 316);
            this.button_scan.Name = "button_scan";
            this.button_scan.Size = new System.Drawing.Size(95, 33);
            this.button_scan.TabIndex = 0;
            this.button_scan.Text = "Scan";
            this.button_scan.Click += new System.EventHandler(this.button_scan_Click);
            // 
            // textBox_display
            // 
            this.textBox_display.Location = new System.Drawing.Point(12, 280);
            this.textBox_display.Name = "textBox_display";
            this.textBox_display.Size = new System.Drawing.Size(293, 20);
            this.textBox_display.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(12, 74);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(334, 165);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // display
            // 
            this.display.AutoSize = true;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.SystemColors.Highlight;
            this.display.Location = new System.Drawing.Point(9, 252);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(53, 16);
            this.display.TabIndex = 3;
            this.display.Text = "Display";
            this.display.Click += new System.EventHandler(this.Display_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Camera";
            // 
            // comboBox_camera
            // 
            this.comboBox_camera.FormattingEnabled = true;
            this.comboBox_camera.Location = new System.Drawing.Point(74, 35);
            this.comboBox_camera.Name = "comboBox_camera";
            this.comboBox_camera.Size = new System.Drawing.Size(231, 21);
            this.comboBox_camera.TabIndex = 5;
            this.comboBox_camera.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // barcode_exit
            // 
            this.barcode_exit.AutoSize = true;
            this.barcode_exit.BackColor = System.Drawing.Color.Red;
            this.barcode_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcode_exit.ForeColor = System.Drawing.Color.White;
            this.barcode_exit.Location = new System.Drawing.Point(332, 9);
            this.barcode_exit.Name = "barcode_exit";
            this.barcode_exit.Size = new System.Drawing.Size(19, 18);
            this.barcode_exit.TabIndex = 6;
            this.barcode_exit.Text = "X";
            this.barcode_exit.Click += new System.EventHandler(this.barcode_exit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 2;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(210, 316);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(95, 33);
            this.guna2GradientButton1.TabIndex = 7;
            this.guna2GradientButton1.Text = "Finish";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // BarCodeScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 361);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.barcode_exit);
            this.Controls.Add(this.comboBox_camera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.display);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.textBox_display);
            this.Controls.Add(this.button_scan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BarCodeScanner";
            this.Text = "Bar code or QR code Scanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton button_scan;
        private System.Windows.Forms.TextBox textBox_display;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_camera;
        private System.Windows.Forms.Label barcode_exit;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}