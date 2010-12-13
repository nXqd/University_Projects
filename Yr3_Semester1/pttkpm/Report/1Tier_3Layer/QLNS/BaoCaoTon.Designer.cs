namespace QLNS
{
    partial class BaoCaoTon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCaoTon));
            this.button1 = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhatSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.qLNSDataSet = new QLNS.QLNSDataSet();
            this.qLNSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(133, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lập báo cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sach,
            this.TonDau,
            this.PhatSinh,
            this.TonCuoi});
            this.grid.Location = new System.Drawing.Point(12, 42);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(447, 297);
            this.grid.TabIndex = 1;
            // 
            // Sach
            // 
            this.Sach.HeaderText = "Sach";
            this.Sach.Name = "Sach";
            this.Sach.ReadOnly = true;
            // 
            // TonDau
            // 
            this.TonDau.HeaderText = "Tồn đầu";
            this.TonDau.Name = "TonDau";
            this.TonDau.ReadOnly = true;
            // 
            // PhatSinh
            // 
            this.PhatSinh.HeaderText = "Phát Sinh";
            this.PhatSinh.Name = "PhatSinh";
            this.PhatSinh.ReadOnly = true;
            // 
            // TonCuoi
            // 
            this.TonCuoi.HeaderText = "TồnCuối";
            this.TonCuoi.Name = "TonCuoi";
            this.TonCuoi.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tháng";
            // 
            // txtThang
            // 
            this.txtThang.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThang.Location = new System.Drawing.Point(201, 12);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(100, 21);
            this.txtThang.TabIndex = 3;
            // 
            // qLNSDataSet
            // 
            this.qLNSDataSet.DataSetName = "QLNSDataSet";
            this.qLNSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLNSDataSetBindingSource
            // 
            this.qLNSDataSetBindingSource.DataSource = this.qLNSDataSet;
            this.qLNSDataSetBindingSource.Position = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(235, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Bỏ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BaoCaoTon
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
            this.Name = "BaoCaoTon";
            this.Text = "BaoCaoTon";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThang;
        private QLNSDataSet qLNSDataSet;
        private System.Windows.Forms.BindingSource qLNSDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TonDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhatSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TonCuoi;
        private System.Windows.Forms.Button button2;
    }
}