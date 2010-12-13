namespace QLNS
{
    partial class ThayDoiThamSo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThayDoiThamSo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkChoTraDu = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNhapNN = new System.Windows.Forms.TextBox();
            this.txtTonLN = new System.Windows.Forms.TextBox();
            this.txtTonNN = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lượng nhập tối thiểu của một đầu sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lượng tồn tối thiểu một đầu sách sau khi nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cho phép khách hàng trả tiền nhiều hơn tiền nợ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lượng tồn tối đa của một đầu sách để được nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nợ tối đa của một khách hàng";
            this.label5.Click += new System.EventHandler(this.Label5Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkChoTraDu);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtNhapNN);
            this.groupBox1.Controls.Add(this.txtTonLN);
            this.groupBox1.Controls.Add(this.txtTonNN);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 253);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THAY ĐỔI QUY ĐỊNH";
            // 
            // chkChoTraDu
            // 
            this.chkChoTraDu.AutoSize = true;
            this.chkChoTraDu.Location = new System.Drawing.Point(291, 171);
            this.chkChoTraDu.Name = "chkChoTraDu";
            this.chkChoTraDu.Size = new System.Drawing.Size(15, 14);
            this.chkChoTraDu.TabIndex = 12;
            this.chkChoTraDu.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Bỏ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // txtNhapNN
            // 
            this.txtNhapNN.Location = new System.Drawing.Point(291, 65);
            this.txtNhapNN.Name = "txtNhapNN";
            this.txtNhapNN.Size = new System.Drawing.Size(81, 21);
            this.txtNhapNN.TabIndex = 9;
            this.txtNhapNN.TextChanged += new System.EventHandler(this.TextBox5TextChanged);
            // 
            // txtTonLN
            // 
            this.txtTonLN.Location = new System.Drawing.Point(291, 132);
            this.txtTonLN.Name = "txtTonLN";
            this.txtTonLN.Size = new System.Drawing.Size(81, 21);
            this.txtTonLN.TabIndex = 8;
            // 
            // txtTonNN
            // 
            this.txtTonNN.Location = new System.Drawing.Point(291, 99);
            this.txtTonNN.Name = "txtTonNN";
            this.txtTonNN.Size = new System.Drawing.Size(81, 21);
            this.txtTonNN.TabIndex = 6;
            this.txtTonNN.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(291, 30);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(81, 21);
            this.txtNo.TabIndex = 5;
            // 
            // ThayDoiThamSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 269);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(423, 313);
            this.MinimumSize = new System.Drawing.Size(423, 313);
            this.Name = "ThayDoiThamSo";
            this.Text = "ThayDoiThamSo";
            this.Load += new System.EventHandler(this.ThayDoiThamSo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNhapNN;
        private System.Windows.Forms.TextBox txtTonLN;
        private System.Windows.Forms.TextBox txtTonNN;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkChoTraDu;
    }
}