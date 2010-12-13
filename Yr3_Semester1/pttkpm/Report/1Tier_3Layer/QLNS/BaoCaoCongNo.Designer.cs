namespace QLNS
{
    partial class BaoCaoCongNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCaoCongNo));
            this.button1 = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhatSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(134, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lập báo cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KhachHang,
            this.NoDau,
            this.PhatSinh,
            this.NoCuoi});
            this.grid.Location = new System.Drawing.Point(12, 34);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(447, 290);
            this.grid.TabIndex = 1;
            // 
            // KhachHang
            // 
            this.KhachHang.HeaderText = "Khách hàng";
            this.KhachHang.Name = "KhachHang";
            // 
            // NoDau
            // 
            this.NoDau.HeaderText = "Nợ đầu";
            this.NoDau.Name = "NoDau";
            this.NoDau.ReadOnly = true;
            // 
            // PhatSinh
            // 
            this.PhatSinh.HeaderText = "Phát sinh";
            this.PhatSinh.Name = "PhatSinh";
            this.PhatSinh.ReadOnly = true;
            // 
            // NoCuoi
            // 
            this.NoCuoi.HeaderText = "Nợ cuối";
            this.NoCuoi.Name = "NoCuoi";
            this.NoCuoi.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tháng :";
            // 
            // txtThang
            // 
            this.txtThang.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang.Location = new System.Drawing.Point(200, 8);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(100, 21);
            this.txtThang.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(247, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // BaoCaoCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 371);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(494, 415);
            this.MinimumSize = new System.Drawing.Size(494, 415);
            this.Name = "BaoCaoCongNo";
            this.Text = "BaoCaoCongNo";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhatSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoCuoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Button button2;
    }
}