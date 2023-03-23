namespace SaleWinApp
{
    partial class frmPersonalManagement
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
            this.btn_PersonalInfo = new System.Windows.Forms.Button();
            this.dgv_Order = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShippedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Freight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_OrderDetail = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Welcome = new System.Windows.Forms.Label();
            this.label_Hidden = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_PersonalInfo
            // 
            this.btn_PersonalInfo.Location = new System.Drawing.Point(1410, 61);
            this.btn_PersonalInfo.Name = "btn_PersonalInfo";
            this.btn_PersonalInfo.Size = new System.Drawing.Size(185, 34);
            this.btn_PersonalInfo.TabIndex = 0;
            this.btn_PersonalInfo.Text = "Personal Infomation";
            this.btn_PersonalInfo.UseVisualStyleBackColor = true;
            this.btn_PersonalInfo.Click += new System.EventHandler(this.btn_PersonalInfo_Click);
            // 
            // dgv_Order
            // 
            this.dgv_Order.AllowUserToAddRows = false;
            this.dgv_Order.AllowUserToDeleteRows = false;
            this.dgv_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.OrderDate,
            this.RequiredDate,
            this.ShippedDate,
            this.Freight});
            this.dgv_Order.Location = new System.Drawing.Point(12, 230);
            this.dgv_Order.MultiSelect = false;
            this.dgv_Order.Name = "dgv_Order";
            this.dgv_Order.ReadOnly = true;
            this.dgv_Order.RowHeadersWidth = 62;
            this.dgv_Order.RowTemplate.Height = 33;
            this.dgv_Order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Order.Size = new System.Drawing.Size(917, 364);
            this.dgv_Order.TabIndex = 1;
            this.dgv_Order.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Order_CellContentClick);
            this.dgv_Order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Order_CellContentClick);
            // 
            // OrderId
            // 
            this.OrderId.HeaderText = "Order Id";
            this.OrderId.MinimumWidth = 8;
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            this.OrderId.Width = 150;
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.MinimumWidth = 8;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            this.OrderDate.Width = 150;
            // 
            // RequiredDate
            // 
            this.RequiredDate.HeaderText = "Required Date";
            this.RequiredDate.MinimumWidth = 8;
            this.RequiredDate.Name = "RequiredDate";
            this.RequiredDate.ReadOnly = true;
            this.RequiredDate.Width = 200;
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
            this.Freight.HeaderText = "Frieght";
            this.Freight.MinimumWidth = 8;
            this.Freight.Name = "Freight";
            this.Freight.ReadOnly = true;
            this.Freight.Width = 150;
            // 
            // dgv_OrderDetail
            // 
            this.dgv_OrderDetail.AllowUserToAddRows = false;
            this.dgv_OrderDetail.AllowUserToDeleteRows = false;
            this.dgv_OrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Price,
            this.Quantity,
            this.Discount});
            this.dgv_OrderDetail.Location = new System.Drawing.Point(935, 230);
            this.dgv_OrderDetail.MultiSelect = false;
            this.dgv_OrderDetail.Name = "dgv_OrderDetail";
            this.dgv_OrderDetail.ReadOnly = true;
            this.dgv_OrderDetail.RowHeadersWidth = 62;
            this.dgv_OrderDetail.RowTemplate.Height = 33;
            this.dgv_OrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_OrderDetail.Size = new System.Drawing.Size(667, 364);
            this.dgv_OrderDetail.TabIndex = 2;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 8;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 150;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 8;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 150;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount(%)";
            this.Discount.MinimumWidth = 8;
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Width = 150;
            // 
            // label_Welcome
            // 
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Welcome.Location = new System.Drawing.Point(41, 33);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(222, 41);
            this.label_Welcome.TabIndex = 3;
            this.label_Welcome.Text = "Welcom Back: ";
            // 
            // label_Hidden
            // 
            this.label_Hidden.AutoSize = true;
            this.label_Hidden.Location = new System.Drawing.Point(404, 56);
            this.label_Hidden.Name = "label_Hidden";
            this.label_Hidden.Size = new System.Drawing.Size(0, 25);
            this.label_Hidden.TabIndex = 4;
            this.label_Hidden.Visible = false;
            // 
            // frmPersonalManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 601);
            this.Controls.Add(this.label_Hidden);
            this.Controls.Add(this.label_Welcome);
            this.Controls.Add(this.dgv_OrderDetail);
            this.Controls.Add(this.dgv_Order);
            this.Controls.Add(this.btn_PersonalInfo);
            this.Name = "frmPersonalManagement";
            this.Text = "Personal Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_PersonalInfo;
        private System.Windows.Forms.DataGridView dgv_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShippedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Freight;
        private System.Windows.Forms.DataGridView dgv_OrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.Label label_Welcome;
        private System.Windows.Forms.Label label_Hidden;
    }
}