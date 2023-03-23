using BussinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmProductManagement : Form
    {
        CategoryRepository _categoryRepository = new CategoryRepository();
        ProductRepository _productRepository = new ProductRepository();
        IEnumerable<Product> _productList = new List<Product>();
        public frmProductManagement() {
            InitializeComponent();
            this.AutoLoadDataInto_DGV();
        }

        private void btn_ReloadData_Click(object sender, EventArgs e) {
            this.AutoLoadDataInto_DGV();
        }

        private void btn_Delete_Click(object sender, EventArgs e) {
            DialogResult _dialogResult;
            _dialogResult = MessageBox.Show("Do you really want to delete chosen Product?", "Management", (MessageBoxButtons)MessageBoxDefaultButton.Button1);
            if (_dialogResult == DialogResult.OK) {
                var temp = _productRepository.GetProductById(Int32.Parse(dgv_Product.SelectedRows[0].Cells[0].Value.ToString()));
                _productRepository.RemoveProduct(temp);
                this.AutoLoadDataInto_DGV();
                MessageBox.Show("Deleted the chosen product.");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e) {
            var _tempProduct = _productRepository.GetProductById(Int32.Parse(dgv_Product.SelectedRows[0].Cells[0].Value.ToString()));
            var frmProductUpdate = new frmProductUpdate(_tempProduct);
            frmProductUpdate.ShowDialog();
        }

        private void btn_Add_Click(object sender, EventArgs e) {
            frmProductCreate frmProductCreate = new frmProductCreate();
            frmProductCreate.Show();
        }
        #region [ Search By ]
        //by product name
        private void tB_SearchProduct_TextChanged(object sender, EventArgs e) {
            _productList = _productRepository.FilterProductListByName(tB_SearchProduct.Text); 
            this.LoadDataInto_DGV(_productList);
        }
        //by product price
        private void tB_SearchProductByPrice_TextChanged(object sender, EventArgs e) {
            _productList = _productRepository.FilterProductListByPrice(tB_SearchProductByPrice.Text);
            this.LoadDataInto_DGV(_productList);
        }

        //by product No. Instock
        private void tB_SearchProductByInstock_TextChanged(object sender, EventArgs e) {
            _productList = _productRepository.FilterProductListByNoInstock(tB_SearchProductByInstock.Text);
            this.LoadDataInto_DGV(_productList);
        }

        //by product Id
        private void tB_SearchProductById_TextChanged(object sender, EventArgs e) {
            _productList = _productRepository.FilterProductListById(tB_SearchProductById.Text);
            this.LoadDataInto_DGV(_productList);
        }
        #endregion

        #region [ DGV - functions ]
        private void dgv_Product_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (dgv_Product.SelectedRows.Count == 1) {
                btn_Delete.Enabled = true;
                btn_Update.Enabled = true;
            } else {
                btn_Update.Enabled = false;
                btn_Delete.Enabled = false;
            }
        }

        public void AutoLoadDataInto_DGV() {
            _productList = _productRepository.GetProductList();
            this.LoadDataInto_DGV(_productList);
        }

        public void LoadDataInto_DGV(IEnumerable<Product> _productList) {
            dgv_Product.Rows.Clear();
            foreach (var _product in _productList) {
                var _category = _categoryRepository.GetCategoryById(_product.CategoryId);
                dgv_Product.Rows.Add(_product.ProductId, _category.CategoryName.ToString(), _product.ProductName, _product.Weight, _product.UnitPrice, _product.UnitsInStock);
            }
        }
        #endregion
    }
}
