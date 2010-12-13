namespace QLNS
{
    partial class DanhSachSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachSach));
            this.Grid = new System.Windows.Forms.DataGridView();
            this.maSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongTonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAUSACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNSDataSet = new QLNS.QLNSDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dAUSACHTableAdapter = new QLNS.QLNSDataSetTableAdapters.DAUSACHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUSACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToOrderColumns = true;
            this.Grid.AutoGenerateColumns = false;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSachDataGridViewTextBoxColumn,
            this.tenSachDataGridViewTextBoxColumn,
            this.theLoaiDataGridViewTextBoxColumn,
            this.tacGiaDataGridViewTextBoxColumn,
            this.luongTonDataGridViewTextBoxColumn});
            this.Grid.DataSource = this.dAUSACHBindingSource;
            this.Grid.Location = new System.Drawing.Point(6, 56);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(544, 237);
            this.Grid.TabIndex = 0;
            // 
            // maSachDataGridViewTextBoxColumn
            // 
            this.maSachDataGridViewTextBoxColumn.DataPropertyName = "MaSach";
            this.maSachDataGridViewTextBoxColumn.HeaderText = "MaSach";
            this.maSachDataGridViewTextBoxColumn.Name = "maSachDataGridViewTextBoxColumn";
            this.maSachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenSachDataGridViewTextBoxColumn
            // 
            this.tenSachDataGridViewTextBoxColumn.DataPropertyName = "TenSach";
            this.tenSachDataGridViewTextBoxColumn.HeaderText = "TenSach";
            this.tenSachDataGridViewTextBoxColumn.Name = "tenSachDataGridViewTextBoxColumn";
            this.tenSachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // theLoaiDataGridViewTextBoxColumn
            // 
            this.theLoaiDataGridViewTextBoxColumn.DataPropertyName = "TheLoai";
            this.theLoaiDataGridViewTextBoxColumn.HeaderText = "TheLoai";
            this.theLoaiDataGridViewTextBoxColumn.Name = "theLoaiDataGridViewTextBoxColumn";
            this.theLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tacGiaDataGridViewTextBoxColumn
            // 
            this.tacGiaDataGridViewTextBoxColumn.DataPropertyName = "TacGia";
            this.tacGiaDataGridViewTextBoxColumn.HeaderText = "TacGia";
            this.tacGiaDataGridViewTextBoxColumn.Name = "tacGiaDataGridViewTextBoxColumn";
            this.tacGiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // luongTonDataGridViewTextBoxColumn
            // 
            this.luongTonDataGridViewTextBoxColumn.DataPropertyName = "LuongTon";
            this.luongTonDataGridViewTextBoxColumn.HeaderText = "LuongTon";
            this.luongTonDataGridViewTextBoxColumn.Name = "luongTonDataGridViewTextBoxColumn";
            this.luongTonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dAUSACHBindingSource
            // 
            this.dAUSACHBindingSource.DataMember = "DAUSACH";
            this.dAUSACHBindingSource.DataSource = this.qLNSDataSet;
            // 
            // qLNSDataSet
            // 
            this.qLNSDataSet.DataSetName = "QLNSDataSet";
            this.qLNSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(233, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Đóng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Grid);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 341);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sách";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1Enter);
            // 
            // txtSearch
            // 
            this.txtSearch.CausesValidation = false;
            this.txtSearch.Location = new System.Drawing.Point(403, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(147, 21);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.OnTextChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // dAUSACHTableAdapter
            // 
            this.dAUSACHTableAdapter.ClearBeforeFill = true;
            // 
            // DanhSachSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(576, 364);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(598, 408);
            this.MinimumSize = new System.Drawing.Size(598, 408);
            this.Name = "DanhSachSach";
            this.Text = "DanhSachSach";
            this.Load += new System.EventHandler(this.DanhSachSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAUSACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid;
        private QLNSDataSet qLNSDataSet;
        private System.Windows.Forms.BindingSource dAUSACHBindingSource;
        private QLNS.QLNSDataSetTableAdapters.DAUSACHTableAdapter dAUSACHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongTonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}