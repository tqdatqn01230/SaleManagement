namespace SaleWinApp
{
    partial class frmOrderManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dgv_Order = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShippedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Freight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ReloadData = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.dTP_FromDate = new System.Windows.Forms.DateTimePicker();
            this.dTP_ToDate = new System.Windows.Forms.DateTimePicker();
            this.label_FromDate = new System.Windows.Forms.Label();
            this.label_ToDate = new System.Windows.Forms.Label();
            this.btn_Report = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Order
            // 
            this.dgv_Order.AllowUserToAddRows = false;
            this.dgv_Order.AllowUserToDeleteRows = false;
            this.dgv_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.MemberId,
            this.OrderDate,
            this.RequireDate,
            this.ShippedDate,
            this.Freight});
            this.dgv_Order.Location = new System.Drawing.Point(10, 170);
            this.dgv_Order.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Order.MultiSelect = false;
            this.dgv_Order.Name = "dgv_Order";
            this.dgv_Order.ReadOnly = true;
            this.dgv_Order.RowHeadersWidth = 62;
            this.dgv_Order.RowTemplate.Height = 33;
            this.dgv_Order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Order.Size = new System.Drawing.Size(939, 288);
            this.dgv_Order.TabIndex = 0;
            this.dgv_Order.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Order_CellClick);
            this.dgv_Order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Order_CellClick);
            // 
            // OrderId
            // 
            this.OrderId.HeaderText = "Order ID";
            this.OrderId.MinimumWidth = 8;
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            this.OrderId.Width = 150;
            // 
            // MemberId
            // 
            this.MemberId.HeaderText = "Member Email";
            this.MemberId.MinimumWidth = 8;
            this.MemberId.Name = "MemberId";
            this.MemberId.ReadOnly = true;
            this.MemberId.Width = 200;
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "OrderDate";
            this.OrderDate.MinimumWidth = 8;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            this.OrderDate.Width = 200;
            // 
            // RequireDate
            // 
            this.RequireDate.HeaderText = "Require Date";
            this.RequireDate.MinimumWidth = 8;
            this.RequireDate.Name = "RequireDate";
            this.RequireDate.ReadOnly = true;
            this.RequireDate.Width = 200;
            // 
            // ShippedDate
            // 
            this.ShippedDate.HeaderText = "Shipped Date";
            this.ShippedDate.MinimumWidth = 8;
            this.ShippedDate.Name = "ShippedDate";
            this.ShippedDate.ReadOnly = true;
            this.ShippedDate.Width = 200;
            // 
            // Freight
            // 
            this.Freight.HeaderText = "Freight";
            this.Freight.MinimumWidth = 8;
            this.Freight.Name = "Freight";
            this.Freight.ReadOnly = true;
            this.Freight.Width = 150;
            // 
            // btn_ReloadData
            // 
            this.btn_ReloadData.Location = new System.Drawing.Point(798, 138);
            this.btn_ReloadData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ReloadData.Name = "btn_ReloadData";
            this.btn_ReloadData.Size = new System.Drawing.Size(139, 27);
            this.btn_ReloadData.TabIndex = 1;
            this.btn_ReloadData.Text = "Reload Data";
            this.btn_ReloadData.UseVisualStyleBackColor = true;
            this.btn_ReloadData.Click += new System.EventHandler(this.btn_ReloadData_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Location = new System.Drawing.Point(798, 98);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(139, 27);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete Order";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(798, 17);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(139, 27);
            this.btn_Create.TabIndex = 3;
            this.btn_Create.Text = "Create new Order";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Enabled = false;
            this.btn_Update.Location = new System.Drawing.Point(798, 59);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(139, 27);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Update Order";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // dTP_FromDate
            // 
            this.dTP_FromDate.Location = new System.Drawing.Point(86, 12);
            this.dTP_FromDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dTP_FromDate.Name = "dTP_FromDate";
            this.dTP_FromDate.Size = new System.Drawing.Size(241, 27);
            this.dTP_FromDate.TabIndex = 5;
            // 
            // dTP_ToDate
            // 
            this.dTP_ToDate.Location = new System.Drawing.Point(86, 62);
            this.dTP_ToDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dTP_ToDate.Name = "dTP_ToDate";
            this.dTP_ToDate.Size = new System.Drawing.Size(241, 27);
            this.dTP_ToDate.TabIndex = 6;
            // 
            // label_FromDate
            // 
            this.label_FromDate.AutoSize = true;
            this.label_FromDate.Location = new System.Drawing.Point(18, 17);
            this.label_FromDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_FromDate.Name = "label_FromDate";
            this.label_FromDate.Size = new System.Drawing.Size(46, 20);
            this.label_FromDate.TabIndex = 7;
            this.label_FromDate.Text = "From:";
            // 
            // label_ToDate
            // 
            this.label_ToDate.AutoSize = true;
            this.label_ToDate.Location = new System.Drawing.Point(18, 66);
            this.label_ToDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ToDate.Name = "label_ToDate";
            this.label_ToDate.Size = new System.Drawing.Size(28, 20);
            this.label_ToDate.TabIndex = 8;
            this.label_ToDate.Text = "To:";
            // 
            // btn_Report
            // 
            this.btn_Report.Location = new System.Drawing.Point(18, 110);
            this.btn_Report.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(128, 27);
            this.btn_Report.TabIndex = 9;
            this.btn_Report.Text = "Generate Report:";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total Money";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sale Report";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(533, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(533, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 14;
            // 
            // frmOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 467);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Report);
            this.Controls.Add(this.label_ToDate);
            this.Controls.Add(this.label_FromDate);
            this.Controls.Add(this.dTP_ToDate);
            this.Controls.Add(this.dTP_FromDate);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_ReloadData);
            this.Controls.Add(this.dgv_Order);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmOrderManagement";
            this.Text = "OrderManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShippedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Freight;
        private System.Windows.Forms.Button btn_ReloadData;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DateTimePicker dTP_FromDate;
        private System.Windows.Forms.DateTimePicker dTP_ToDate;
        private System.Windows.Forms.Label label_FromDate;
        private System.Windows.Forms.Label label_ToDate;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}