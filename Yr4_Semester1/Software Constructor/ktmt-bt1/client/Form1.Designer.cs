namespace client
{
    partial class Form1
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
            this.btEnter = new System.Windows.Forms.Button();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.property = new System.Windows.Forms.Panel();
            this.dgStudentList = new System.Windows.Forms.DataGridView();
            this.tStatus = new System.Windows.Forms.Label();
            this.property.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // btEnter
            // 
            this.btEnter.Location = new System.Drawing.Point(53, 39);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(75, 23);
            this.btEnter.TabIndex = 0;
            this.btEnter.Text = "Enter";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.BtEnterClick);
            // 
            // tbPort
            // 
            this.tbPort.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbPort.Location = new System.Drawing.Point(41, 12);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 21);
            this.tbPort.TabIndex = 1;
            this.tbPort.Text = "Enter port here";
            // 
            // property
            // 
            this.property.Controls.Add(this.tStatus);
            this.property.Controls.Add(this.btEnter);
            this.property.Controls.Add(this.tbPort);
            this.property.Dock = System.Windows.Forms.DockStyle.Left;
            this.property.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.property.Location = new System.Drawing.Point(0, 0);
            this.property.Name = "property";
            this.property.Size = new System.Drawing.Size(181, 304);
            this.property.TabIndex = 2;
            // 
            // dgStudentList
            // 
            this.dgStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgStudentList.Location = new System.Drawing.Point(181, 0);
            this.dgStudentList.Name = "dgStudentList";
            this.dgStudentList.Size = new System.Drawing.Size(533, 304);
            this.dgStudentList.TabIndex = 3;
            this.dgStudentList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgStudentListCellEndEdit);
            // 
            // tStatus
            // 
            this.tStatus.AutoSize = true;
            this.tStatus.Location = new System.Drawing.Point(12, 282);
            this.tStatus.Name = "tStatus";
            this.tStatus.Size = new System.Drawing.Size(43, 13);
            this.tStatus.TabIndex = 2;
            this.tStatus.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 304);
            this.Controls.Add(this.dgStudentList);
            this.Controls.Add(this.property);
            this.Name = "Form1";
            this.Text = "Form1";
            this.property.ResumeLayout(false);
            this.property.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Panel property;
        private System.Windows.Forms.DataGridView dgStudentList;
        private System.Windows.Forms.Label tStatus;
    }
}

