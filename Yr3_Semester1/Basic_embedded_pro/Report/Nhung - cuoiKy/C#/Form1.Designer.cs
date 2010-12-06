namespace BT_CuoiKy
{
    partial class iSerial
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
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.txtIn = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.gbxCSPSetting = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxStopBits = new System.Windows.Forms.ComboBox();
            this.cbxDataBits = new System.Windows.Forms.ComboBox();
            this.cbxComPort = new System.Windows.Forms.ComboBox();
            this.cbxParity = new System.Windows.Forms.ComboBox();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btOpenPort = new System.Windows.Forms.Button();
            this.lbAbout = new System.Windows.Forms.Label();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.gbxCSPSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIn
            // 
            this.txtIn.Enabled = false;
            this.txtIn.Location = new System.Drawing.Point(104, 150);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(311, 21);
            this.txtIn.TabIndex = 1;
            this.txtIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIn_KeyDown);
            // 
            // btSend
            // 
            this.btSend.ImageKey = "(none)";
            this.btSend.Location = new System.Drawing.Point(440, 148);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(92, 23);
            this.btSend.TabIndex = 2;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(539, 147);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(93, 23);
            this.btClear.TabIndex = 3;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // gbxCSPSetting
            // 
            this.gbxCSPSetting.Controls.Add(this.label6);
            this.gbxCSPSetting.Controls.Add(this.label5);
            this.gbxCSPSetting.Controls.Add(this.label4);
            this.gbxCSPSetting.Controls.Add(this.label3);
            this.gbxCSPSetting.Controls.Add(this.label2);
            this.gbxCSPSetting.Controls.Add(this.cbxStopBits);
            this.gbxCSPSetting.Controls.Add(this.cbxDataBits);
            this.gbxCSPSetting.Controls.Add(this.cbxComPort);
            this.gbxCSPSetting.Controls.Add(this.cbxParity);
            this.gbxCSPSetting.Controls.Add(this.cbxBaudRate);
            this.gbxCSPSetting.Location = new System.Drawing.Point(14, 187);
            this.gbxCSPSetting.Name = "gbxCSPSetting";
            this.gbxCSPSetting.Size = new System.Drawing.Size(519, 83);
            this.gbxCSPSetting.TabIndex = 4;
            this.gbxCSPSetting.TabStop = false;
            this.gbxCSPSetting.Text = "Com Serial Port Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Stop Bits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Parity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Baud Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "COM Port";
            // 
            // cbxStopBits
            // 
            this.cbxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStopBits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxStopBits.FormattingEnabled = true;
            this.cbxStopBits.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.cbxStopBits.Location = new System.Drawing.Point(408, 56);
            this.cbxStopBits.Name = "cbxStopBits";
            this.cbxStopBits.Size = new System.Drawing.Size(93, 21);
            this.cbxStopBits.TabIndex = 4;
            // 
            // cbxDataBits
            // 
            this.cbxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDataBits.FormattingEnabled = true;
            this.cbxDataBits.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cbxDataBits.Location = new System.Drawing.Point(308, 56);
            this.cbxDataBits.Name = "cbxDataBits";
            this.cbxDataBits.Size = new System.Drawing.Size(93, 21);
            this.cbxDataBits.TabIndex = 3;
            // 
            // cbxComPort
            // 
            this.cbxComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComPort.FormattingEnabled = true;
            this.cbxComPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.cbxComPort.Location = new System.Drawing.Point(7, 56);
            this.cbxComPort.Name = "cbxComPort";
            this.cbxComPort.Size = new System.Drawing.Size(93, 21);
            this.cbxComPort.TabIndex = 3;
            // 
            // cbxParity
            // 
            this.cbxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxParity.FormattingEnabled = true;
            this.cbxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cbxParity.Location = new System.Drawing.Point(208, 56);
            this.cbxParity.Name = "cbxParity";
            this.cbxParity.Size = new System.Drawing.Size(93, 21);
            this.cbxParity.TabIndex = 2;
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "28800"});
            this.cbxBaudRate.Location = new System.Drawing.Point(107, 56);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(93, 21);
            this.cbxBaudRate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Send Data";
            // 
            // btOpenPort
            // 
            this.btOpenPort.Location = new System.Drawing.Point(545, 196);
            this.btOpenPort.Name = "btOpenPort";
            this.btOpenPort.Size = new System.Drawing.Size(87, 23);
            this.btOpenPort.TabIndex = 6;
            this.btOpenPort.Text = "Open Port";
            this.btOpenPort.UseVisualStyleBackColor = true;
            this.btOpenPort.Click += new System.EventHandler(this.btOpenPort_Click);
            // 
            // lbAbout
            // 
            this.lbAbout.AutoSize = true;
            this.lbAbout.Location = new System.Drawing.Point(545, 243);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(40, 13);
            this.lbAbout.TabIndex = 7;
            this.lbAbout.Text = "About";
            this.lbAbout.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(14, 13);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOut.Size = new System.Drawing.Size(618, 128);
            this.txtOut.TabIndex = 8;
            // 
            // iSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 296);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.lbAbout);
            this.Controls.Add(this.btOpenPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxCSPSetting);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.txtIn);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(660, 334);
            this.MinimumSize = new System.Drawing.Size(660, 334);
            this.Name = "iSerial";
            this.Text = "iSerial";
            this.Load += new System.EventHandler(this.iSerial_Load);
            this.gbxCSPSetting.ResumeLayout(false);
            this.gbxCSPSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.GroupBox gbxCSPSetting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxStopBits;
        private System.Windows.Forms.ComboBox cbxDataBits;
        private System.Windows.Forms.ComboBox cbxComPort;
        private System.Windows.Forms.ComboBox cbxParity;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOpenPort;
        private System.Windows.Forms.Label lbAbout;
        private System.Windows.Forms.TextBox txtOut;
    }
}

