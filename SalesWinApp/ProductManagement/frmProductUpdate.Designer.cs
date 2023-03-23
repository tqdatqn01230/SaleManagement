namespace SaleWinApp
{
    partial class frmProductUpdate
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
            this.label_ProductId = new System.Windows.Forms.Label();
            this.label_ProductCategory = new System.Windows.Forms.Label();
            this.label_ProductName = new System.Windows.Forms.Label();
            this.label_UnitPrice = new System.Windows.Forms.Label();
            this.label_Weight = new System.Windows.Forms.Label();
            this.label_UnitInStock = new System.Windows.Forms.Label();
            this.mTB_ProductId = new System.Windows.Forms.MaskedTextBox();
            this.mTB_UnitPrice = new System.Windows.Forms.MaskedTextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.mTB_Weight = new System.Windows.Forms.MaskedTextBox();
            this.mTB_UnitInStock = new System.Windows.Forms.MaskedTextBox();
            this.cB_Category = new System.Windows.Forms.ComboBox();
            this.tB_ProductName = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ProductId
            // 
            this.label_ProductId.AutoSize = true;
            this.label_ProductId.Location = new System.Drawing.Point(219, 77);
            this.label_ProductId.Name = "label_ProductId";
            this.label_ProductId.Size = new System.Drawing.Size(99, 25);
            this.label_ProductId.TabIndex = 0;
            this.label_ProductId.Text = "Product Id:";
            // 
            // label_ProductCategory
            // 
            this.label_ProductCategory.AutoSize = true;
            this.label_ProductCategory.Location = new System.Drawing.Point(219, 137);
            this.label_ProductCategory.Name = "label_ProductCategory";
            this.label_ProductCategory.Size = new System.Drawing.Size(88, 25);
            this.label_ProductCategory.TabIndex = 1;
            this.label_ProductCategory.Text = "Category:";
            // 
            // label_ProductName
            // 
            this.label_ProductName.AutoSize = true;
            this.label_ProductName.Location = new System.Drawing.Point(219, 197);
            this.label_ProductName.Name = "label_ProductName";
            this.label_ProductName.Size = new System.Drawing.Size(130, 25);
            this.label_ProductName.TabIndex = 2;
            this.label_ProductName.Text = "Product Name:";
            // 
            // label_UnitPrice
            // 
            this.label_UnitPrice.AutoSize = true;
            this.label_UnitPrice.Location = new System.Drawing.Point(219, 314);
            this.label_UnitPrice.Name = "label_UnitPrice";
            this.label_UnitPrice.Size = new System.Drawing.Size(90, 25);
            this.label_UnitPrice.TabIndex = 3;
            this.label_UnitPrice.Text = "Unit Price:";
            // 
            // label_Weight
            // 
            this.label_Weight.AutoSize = true;
            this.label_Weight.Location = new System.Drawing.Point(220, 255);
            this.label_Weight.Name = "label_Weight";
            this.label_Weight.Size = new System.Drawing.Size(98, 25);
            this.label_Weight.TabIndex = 4;
            this.label_Weight.Text = "Weight (g):";
            // 
            // label_UnitInStock
            // 
            this.label_UnitInStock.AutoSize = true;
            this.label_UnitInStock.Location = new System.Drawing.Point(219, 370);
            this.label_UnitInStock.Name = "label_UnitInStock";
            this.label_UnitInStock.Size = new System.Drawing.Size(121, 25);
            this.label_UnitInStock.TabIndex = 5;
            this.label_UnitInStock.Text = "Unit In Stock: ";
            // 
            // mTB_ProductId
            // 
            this.mTB_ProductId.Enabled = false;
            this.mTB_ProductId.Location = new System.Drawing.Point(378, 80);
            this.mTB_ProductId.Mask = "00000";
            this.mTB_ProductId.Name = "mTB_ProductId";
            this.mTB_ProductId.Size = new System.Drawing.Size(207, 31);
            this.mTB_ProductId.TabIndex = 6;
            this.mTB_ProductId.ValidatingType = typeof(int);
            // 
            // mTB_UnitPrice
            // 
            this.mTB_UnitPrice.Location = new System.Drawing.Point(378, 311);
            this.mTB_UnitPrice.Mask = "000000000";
            this.mTB_UnitPrice.Name = "mTB_UnitPrice";
            this.mTB_UnitPrice.Size = new System.Drawing.Size(207, 31);
            this.mTB_UnitPrice.TabIndex = 7;
            this.mTB_UnitPrice.ValidatingType = typeof(int);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Title.Location = new System.Drawing.Point(266, 20);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(207, 36);
            this.label_Title.TabIndex = 8;
            this.label_Title.Text = "Update Product";
            // 
            // mTB_Weight
            // 
            this.mTB_Weight.Location = new System.Drawing.Point(378, 249);
            this.mTB_Weight.Mask = "000000";
            this.mTB_Weight.Name = "mTB_Weight";
            this.mTB_Weight.Size = new System.Drawing.Size(207, 31);
            this.mTB_Weight.TabIndex = 9;
            this.mTB_Weight.ValidatingType = typeof(int);
            // 
            // mTB_UnitInStock
            // 
            this.mTB_UnitInStock.Location = new System.Drawing.Point(378, 370);
            this.mTB_UnitInStock.Mask = "00000";
            this.mTB_UnitInStock.Name = "mTB_UnitInStock";
            this.mTB_UnitInStock.Size = new System.Drawing.Size(207, 31);
            this.mTB_UnitInStock.TabIndex = 10;
            this.mTB_UnitInStock.ValidatingType = typeof(int);
            // 
            // cB_Category
            // 
            this.cB_Category.FormattingEnabled = true;
            this.cB_Category.Location = new System.Drawing.Point(378, 137);
            this.cB_Category.Name = "cB_Category";
            this.cB_Category.Size = new System.Drawing.Size(207, 33);
            this.cB_Category.TabIndex = 11;
            // 
            // tB_ProductName
            // 
            this.tB_ProductName.Location = new System.Drawing.Point(378, 191);
            this.tB_ProductName.Name = "tB_ProductName";
            this.tB_ProductName.Size = new System.Drawing.Size(207, 31);
            this.tB_ProductName.TabIndex = 12;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(473, 478);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(112, 34);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(266, 478);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(112, 34);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frmProductUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tB_ProductName);
            this.Controls.Add(this.cB_Category);
            this.Controls.Add(this.mTB_UnitInStock);
            this.Controls.Add(this.mTB_Weight);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.mTB_UnitPrice);
            this.Controls.Add(this.mTB_ProductId);
            this.Controls.Add(this.label_UnitInStock);
            this.Controls.Add(this.label_Weight);
            this.Controls.Add(this.label_UnitPrice);
            this.Controls.Add(this.label_ProductName);
            this.Controls.Add(this.label_ProductCategory);
            this.Controls.Add(this.label_ProductId);
            this.Name = "frmProductUpdate";
            this.Text = "Product Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ProductId;
        private System.Windows.Forms.Label label_ProductCategory;
        private System.Windows.Forms.Label label_ProductName;
        private System.Windows.Forms.Label label_UnitPrice;
        private System.Windows.Forms.Label label_Weight;
        private System.Windows.Forms.Label label_UnitInStock;
        private System.Windows.Forms.MaskedTextBox mTB_ProductId;
        private System.Windows.Forms.MaskedTextBox mTB_UnitPrice;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.MaskedTextBox mTB_Weight;
        private System.Windows.Forms.MaskedTextBox mTB_UnitInStock;
        private System.Windows.Forms.ComboBox cB_Category;
        private System.Windows.Forms.TextBox tB_ProductName;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
    }
}