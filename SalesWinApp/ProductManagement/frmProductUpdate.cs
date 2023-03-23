using BussinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmProductUpdate : Form
    {
        ProductRepository _productRepository = new ProductRepository();
        CategoryRepository _categoryRepository = new CategoryRepository();
        IEnumerable<Category> _categoryList = new List<Category>();
        public frmProductUpdate(Product _product) {
            InitializeComponent();
            this.AutoLoadDataInto_CB();
            this.AutoLoadDataInto_Inputs(_product);
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            var _tempProduct = _productRepository.GetProductById(Int32.Parse(mTB_ProductId.Text.ToString()));
            this.AutoLoadDataInto_Inputs(_tempProduct);
        }

        private void btn_Save_Click(object sender, EventArgs e) {
            var _tempProductId = _productRepository.GetProductById(Int32.Parse(mTB_ProductId.Text.ToString()));
            if (    cB_Category.SelectedIndex < 0
                ||  tB_ProductName.Text.ToString().Equals("")
                ||  mTB_Weight.Text.ToString().Equals("")
                ||  mTB_UnitPrice.Text.ToString().Equals("")
                ||  mTB_UnitInStock.Text.ToString().Equals("")) {
                MessageBox.Show("Invalid input.");
            }  else {
                var _tempProduct = _productRepository.GetProductById(Int32.Parse(mTB_ProductId.Text.ToString()));
                var _tempCategory = (int)cB_Category.SelectedValue;
                _tempProduct.CategoryId = _tempCategory;
                _tempProduct.ProductName = tB_ProductName.Text.ToString();
                if (_tempCategory == 1) {
                    _tempProduct.Weight = mTB_Weight.Text + "g";
                } else {
                    _tempProduct.Weight = mTB_Weight.Text + "ml";
                }
                
                _tempProduct.UnitPrice = Int32.Parse(mTB_UnitPrice.Text.ToString());
                _tempProduct.UnitsInStock = Int32.Parse(mTB_UnitInStock.Text.ToString());

                _productRepository.UpdateProduct(_tempProduct);
                this.Close();
                MessageBox.Show("Updated successfully");
            }
        }

        public void AutoLoadDataInto_CB() {
            cB_Category.Items.Clear();
            _categoryList = _categoryRepository.GetCategoryList();
            cB_Category.DisplayMember = "CategoryName";
            cB_Category.ValueMember = "CategoryId";
            cB_Category.DataSource = _categoryList;
        }

        public void AutoLoadDataInto_Inputs(Product _product) {
            mTB_ProductId.Text = _product.ProductId.ToString();
            var tempString = _product.Weight.ToString();
            if (_product.CategoryId == 1) {
                cB_Category.SelectedIndex = 0;
                label_Weight.Text = "Weight (g)";
                var _weightString = tempString.Remove(tempString.Length - 1);            
                mTB_Weight.Text = _weightString;
            } else {
                cB_Category.SelectedIndex = 1;
                label_Weight.Text = "Weight (ml)";
                var _weightString = tempString.Remove(tempString.Length - 2);
                mTB_Weight.Text = _weightString;
            }
            tB_ProductName.Text = _product.ProductName.ToString();
            var _tempUnitPrice = _product.UnitPrice.ToString();
            var UnitPriceString = _tempUnitPrice.Remove(_tempUnitPrice.Length - 5);
            mTB_UnitPrice.Text = Int32.Parse(UnitPriceString).ToString();
            mTB_UnitInStock.Text = _product.UnitsInStock.ToString();

        }
    }
}
