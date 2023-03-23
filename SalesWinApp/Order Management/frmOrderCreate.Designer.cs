namespace SaleWinApp
{
    partial class frmOrderCreate
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
            this.label_Title = new System.Windows.Forms.Label();
            this.label_OrderId = new System.Windows.Forms.Label();
            this.label_Member = new System.Windows.Forms.Label();
            this.label_OrderDate = new System.Windows.Forms.Label();
            this.label_RequiredDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_Freight = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.mTB_OrderId = new System.Windows.Forms.MaskedTextBox();
            this.cB_Member = new System.Windows.Forms.ComboBox();
            this.dTP_RequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dTP_ShippedDate = new System.Windows.Forms.DateTimePicker();
            this.mTB_Freight = new System.Windows.Forms.MaskedTextBox();
            this.dTP_OrderDate = new System.Windows.Forms.DateTimePicker();
            this.dgv_OrderDetails = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AddOrderDetail = new System.Windows.Forms.Button();
            this.label_Product = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Product = new System.Windows.Forms.ComboBox();
            this.tb_UnitPrice = new System.Windows.Forms.TextBox();
            this.mtb_Quantity = new System.Windows.Forms.MaskedTextBox();
            this.mtb_Discount = new System.Windows.Forms.MaskedTextBox();
            this.btn_DeleteOrderDetail = new System.Windows.Forms.Button();
            this.btn_CancelOrderDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Title.Location = new System.Drawing.Point(288, 7);
            this.label_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(215, 30);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Create a new Order";
            // 
            // label_OrderId
            // 
            this.label_OrderId.AutoSize = true;
            this.label_OrderId.Location = new System.Drawing.Point(10, 46);
            this.label_OrderId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_OrderId.Name = "label_OrderId";
            this.label_OrderId.Size = new System.Drawing.Size(67, 20);
            this.label_OrderId.TabIndex = 1;
            this.label_OrderId.Text = "Order Id:";
            // 
            // label_Member
            // 
            this.label_Member.AutoSize = true;
            this.label_Member.Location = new System.Drawing.Point(10, 82);
            this.label_Member.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Member.Name = "label_Member";
            this.label_Member.Size = new System.Drawing.Size(68, 20);
            this.label_Member.TabIndex = 2;
            this.label_Member.Text = "Member:";
            // 
            // label_OrderDate
            // 
            this.label_OrderDate.AutoSize = true;
            this.label_OrderDate.Location = new System.Drawing.Point(10, 112);
            this.label_OrderDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_OrderDate.Name = "label_OrderDate";
            this.label_OrderDate.Size = new System.Drawing.Size(86, 20);
            this.label_OrderDate.TabIndex = 3;
            this.label_OrderDate.Text = "Order Date:";
            // 
            // label_RequiredDate
            // 
            this.label_RequiredDate.AutoSize = true;
            this.label_RequiredDate.Location = new System.Drawing.Point(6, 142);
            this.label_RequiredDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_RequiredDate.Name = "label_RequiredDate";
            this.label_RequiredDate.Size = new System.Drawing.Size(108, 20);
            this.label_RequiredDate.TabIndex = 4;
            this.label_RequiredDate.Text = "Required Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Shipped Date:";
            // 
            // label_Freight
            // 
            this.label_Freight.AutoSize = true;
            this.label_Freight.Location = new System.Drawing.Point(10, 201);
            this.label_Freight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Freight.Name = "label_Freight";
            this.label_Freight.Size = new System.Drawing.Size(58, 20);
            this.label_Freight.TabIndex = 6;
            this.label_Freight.Text = "Freight:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(268, 465);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 27);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(426, 465);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(90, 27);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // mTB_OrderId
            // 
            this.mTB_OrderId.Location = new System.Drawing.Point(118, 46);
            this.mTB_OrderId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mTB_OrderId.Mask = "00000";
            this.mTB_OrderId.Name = "mTB_OrderId";
            this.mTB_OrderId.Size = new System.Drawing.Size(146, 27);
            this.mTB_OrderId.TabIndex = 9;
            this.mTB_OrderId.ValidatingType = typeof(int);
            // 
            // cB_Member
            // 
            this.cB_Member.FormattingEnabled = true;
            this.cB_Member.Location = new System.Drawing.Point(118, 76);
            this.cB_Member.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cB_Member.Name = "cB_Member";
            this.cB_Member.Size = new System.Drawing.Size(241, 28);
            this.cB_Member.TabIndex = 10;
            this.cB_Member.TextChanged += new System.EventHandler(this.cB_Member_TextChanged);
            // 
            // dTP_RequiredDate
            // 
            this.dTP_RequiredDate.Location = new System.Drawing.Point(118, 137);
            this.dTP_RequiredDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dTP_RequiredDate.Name = "dTP_RequiredDate";
            this.dTP_RequiredDate.Size = new System.Drawing.Size(241, 27);
            this.dTP_RequiredDate.TabIndex = 11;
            // 
            // dTP_ShippedDate
            // 
            this.dTP_ShippedDate.Location = new System.Drawing.Point(118, 166);
            this.dTP_ShippedDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dTP_ShippedDate.Name = "dTP_ShippedDate";
            this.dTP_ShippedDate.Size = new System.Drawing.Size(241, 27);
            this.dTP_ShippedDate.TabIndex = 12;
            // 
            // mTB_Freight
            // 
            this.mTB_Freight.Location = new System.Drawing.Point(118, 196);
            this.mTB_Freight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mTB_Freight.Mask = "0000000000";
            this.mTB_Freight.Name = "mTB_Freight";
            this.mTB_Freight.Size = new System.Drawing.Size(146, 27);
            this.mTB_Freight.TabIndex = 13;
            this.mTB_Freight.ValidatingType = typeof(int);
            // 
            // dTP_OrderDate
            // 
            this.dTP_OrderDate.Enabled = false;
            this.dTP_OrderDate.Location = new System.Drawing.Point(118, 107);
            this.dTP_OrderDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dTP_OrderDate.Name = "dTP_OrderDate";
            this.dTP_OrderDate.Size = new System.Drawing.Size(241, 27);
            this.dTP_OrderDate.TabIndex = 14;
            // 
            // dgv_OrderDetails
            // 
            this.dgv_OrderDetails.AllowUserToAddRows = false;
            this.dgv_OrderDetails.AllowUserToDeleteRows = false;
            this.dgv_OrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.UnitPrice,
            this.Quantity,
            this.Discount});
            this.dgv_OrderDetails.Location = new System.Drawing.Point(118, 226);
            this.dgv_OrderDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_OrderDetails.Name = "dgv_OrderDetails";
            this.dgv_OrderDetails.ReadOnly = true;
            this.dgv_OrderDetails.RowHeadersWidth = 62;
            this.dgv_OrderDetails.RowTemplate.Height = 33;
            this.dgv_OrderDetails.Size = new System.Drawing.Size(621, 233);
            this.dgv_OrderDetails.TabIndex = 15;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Product";
            this.ProductId.MinimumWidth = 8;
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Width = 150;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.MinimumWidth = 8;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 150;
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
            this.Discount.HeaderText = "Discount (%)";
            this.Discount.MinimumWidth = 8;
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Width = 150;
            // 
            // btn_AddOrderDetail
            // 
            this.btn_AddOrderDetail.Location = new System.Drawing.Point(743, 226);
            this.btn_AddOrderDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AddOrderDetail.Name = "btn_AddOrderDetail";
            this.btn_AddOrderDetail.Size = new System.Drawing.Size(119, 67);
            this.btn_AddOrderDetail.TabIndex = 16;
            this.btn_AddOrderDetail.Text = "Add an \r\nOrder Detail";
            this.btn_AddOrderDetail.UseVisualStyleBackColor = true;
            this.btn_AddOrderDetail.Click += new System.EventHandler(this.btn_AddOrderDetail_Click);
            // 
            // label_Product
            // 
            this.label_Product.AutoSize = true;
            this.label_Product.Location = new System.Drawing.Point(529, 74);
            this.label_Product.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Product.Name = "label_Product";
            this.label_Product.Size = new System.Drawing.Size(63, 20);
            this.label_Product.TabIndex = 18;
            this.label_Product.Text = "Product:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Unit Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Discount (%):";
            // 
            // cb_Product
            // 
            this.cb_Product.FormattingEnabled = true;
            this.cb_Product.Location = new System.Drawing.Point(658, 68);
            this.cb_Product.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Product.Name = "cb_Product";
            this.cb_Product.Size = new System.Drawing.Size(146, 28);
            this.cb_Product.TabIndex = 22;
            this.cb_Product.SelectedIndexChanged += new System.EventHandler(this.cb_Product_SelectedIndexChanged);
            // 
            // tb_UnitPrice
            // 
            this.tb_UnitPrice.Enabled = false;
            this.tb_UnitPrice.Location = new System.Drawing.Point(658, 99);
            this.tb_UnitPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_UnitPrice.Name = "tb_UnitPrice";
            this.tb_UnitPrice.Size = new System.Drawing.Size(146, 27);
            this.tb_UnitPrice.TabIndex = 23;
            // 
            // mtb_Quantity
            // 
            this.mtb_Quantity.Location = new System.Drawing.Point(658, 129);
            this.mtb_Quantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtb_Quantity.Mask = "0000";
            this.mtb_Quantity.Name = "mtb_Quantity";
            this.mtb_Quantity.Size = new System.Drawing.Size(146, 27);
            this.mtb_Quantity.TabIndex = 24;
            // 
            // mtb_Discount
            // 
            this.mtb_Discount.Location = new System.Drawing.Point(658, 158);
            this.mtb_Discount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtb_Discount.Mask = "00";
            this.mtb_Discount.Name = "mtb_Discount";
            this.mtb_Discount.Size = new System.Drawing.Size(146, 27);
            this.mtb_Discount.TabIndex = 25;
            // 
            // btn_DeleteOrderDetail
            // 
            this.btn_DeleteOrderDetail.Location = new System.Drawing.Point(743, 395);
            this.btn_DeleteOrderDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DeleteOrderDetail.Name = "btn_DeleteOrderDetail";
            this.btn_DeleteOrderDetail.Size = new System.Drawing.Size(119, 63);
            this.btn_DeleteOrderDetail.TabIndex = 26;
            this.btn_DeleteOrderDetail.Text = "Delete \r\nOrder Detail";
            this.btn_DeleteOrderDetail.UseVisualStyleBackColor = true;
            this.btn_DeleteOrderDetail.Click += new System.EventHandler(this.btn_DeleteOrderDetail_Click);
            // 
            // btn_CancelOrderDetail
            // 
            this.btn_CancelOrderDetail.Enabled = false;
            this.btn_CancelOrderDetail.Location = new System.Drawing.Point(743, 298);
            this.btn_CancelOrderDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_CancelOrderDetail.Name = "btn_CancelOrderDetail";
            this.btn_CancelOrderDetail.Size = new System.Drawing.Size(119, 53);
            this.btn_CancelOrderDetail.TabIndex = 27;
            this.btn_CancelOrderDetail.Text = "Cancel \r\nOrder Detail";
            this.btn_CancelOrderDetail.UseVisualStyleBackColor = true;
            this.btn_CancelOrderDetail.Click += new System.EventHandler(this.btn_CancelOrderDetail_Click);
            // 
            // frmOrderCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 502);
            this.Controls.Add(this.btn_CancelOrderDetail);
            this.Controls.Add(this.btn_DeleteOrderDetail);
            this.Controls.Add(this.mtb_Discount);
            this.Controls.Add(this.mtb_Quantity);
            this.Controls.Add(this.tb_UnitPrice);
            this.Controls.Add(this.cb_Product);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Product);
            this.Controls.Add(this.btn_AddOrderDetail);
            this.Controls.Add(this.dgv_OrderDetails);
            this.Controls.Add(this.dTP_OrderDate);
            this.Controls.Add(this.mTB_Freight);
            this.Controls.Add(this.dTP_ShippedDate);
            this.Controls.Add(this.dTP_RequiredDate);
            this.Controls.Add(this.cB_Member);
            this.Controls.Add(this.mTB_OrderId);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.label_Freight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_RequiredDate);
            this.Controls.Add(this.label_OrderDate);
            this.Controls.Add(this.label_Member);
            this.Controls.Add(this.label_OrderId);
            this.Controls.Add(this.label_Title);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmOrderCreate";
            this.Text = "Create an Order";
            this.Load += new System.EventHandler(this.frmOrderCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_OrderId;
        private System.Windows.Forms.Label label_Member;
        private System.Windows.Forms.Label label_OrderDate;
        private System.Windows.Forms.Label label_RequiredDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_Freight;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.MaskedTextBox mTB_OrderId;
        private System.Windows.Forms.ComboBox cB_Member;
        private System.Windows.Forms.DateTimePicker dTP_RequiredDate;
        private System.Windows.Forms.DateTimePicker dTP_ShippedDate;
        private System.Windows.Forms.MaskedTextBox mTB_Freight;
        private System.Windows.Forms.DateTimePicker dTP_OrderDate;
        private System.Windows.Forms.DataGridView dgv_OrderDetails;
        private System.Windows.Forms.Button btn_AddOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.Label label_Product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Product;
        private System.Windows.Forms.TextBox tb_UnitPrice;
        private System.Windows.Forms.MaskedTextBox mtb_Quantity;
        private System.Windows.Forms.MaskedTextBox mtb_Discount;
        private System.Windows.Forms.Button btn_DeleteOrderDetail;
        private System.Windows.Forms.Button btn_CancelOrderDetail;
    }
}