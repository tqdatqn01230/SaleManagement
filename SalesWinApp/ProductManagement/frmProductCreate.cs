using BussinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmProductCreate : Form
    {
        ProductRepository _productRepository = new ProductRepository();
        CategoryRepository _categoryRepository = new CategoryRepository();
        IEnumerable<Category> _categoryList;
        public frmProductCreate() {
            InitializeComponent();
            this.AutoLoadDataInto_CB();
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            this.ClearInput();
        }

        private void btn_Save_Click(object sender, EventArgs e) {
            try
            {
                int.Parse(mTB_ProductId.Text.ToString());

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            var _tempProductId = _productRepository.GetProductById(Int32.Parse(mTB_ProductId.Text.ToString()));
            if (    mTB_ProductId.Text.ToString().Equals("")
                ||  cB_Category.SelectedIndex < 0
                ||  tB_ProductName.Text.ToString().Equals("")
                ||  mTB_Weight.Text.ToString().Equals("")
                ||  mTB_UnitPrice.Text.ToString().Equals("")
                ||  mTB_UnitInStock.Text.ToString().Equals("")) {
                MessageBox.Show("Invalid input.");
            } else if (_tempProductId != null){
                MessageBox.Show("Product Id cannot be dupplicated.");
            } else {
                var _tempProduct = new Product();
                _tempProduct.ProductId = Int32.Parse(mTB_ProductId.Text.ToString());
                var _tempCategory = (int)cB_Category.SelectedValue;
                _tempProduct.CategoryId = _tempCategory;
                _tempProduct.ProductName = tB_ProductName.Text.ToString();
                if (_tempCategory == 1) {
                    _tempProduct.Weight = mTB_Weight.Text + "g";
                } else {
                    _tempProduct.Weight = mTB_Weight.Text + "ml";
                }
                
                _tempProduct.UnitPrice = Int32.Parse(mTB_Weight.Text.ToString());
                _tempProduct.UnitsInStock = Int32.Parse(mTB_UnitPrice.Text.ToString());

                _productRepository.AddProduct(_tempProduct);
                this.Close();
                MessageBox.Show("Added successfully");
            }
        }

        public void ClearInput() {
            mTB_ProductId.Clear();
            cB_Category.SelectedIndex = -1;
            tB_ProductName.Clear();
            mTB_Weight.Clear();
            mTB_UnitPrice.Clear();
            mTB_UnitInStock.Clear();
        }

        public void AutoLoadDataInto_CB() {
            cB_Category.Items.Clear();
            _categoryList = _categoryRepository.GetCategoryList();
            cB_Category.DisplayMember = "CategoryName";
            cB_Category.ValueMember = "CategoryId";
            cB_Category.DataSource = _categoryList;
        }
    }
}
