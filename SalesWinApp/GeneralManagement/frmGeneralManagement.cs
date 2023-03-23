using BussinessObject.Models;
using SalesWinApp.Sale_Report;
using System;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmGeneralManagement : Form
    {
        public frmGeneralManagement() {
            InitializeComponent();
        }

        public frmGeneralManagement(Member memberDAO) {
            //InitializeComponent();
        }
        private void btn_MemberManagement_Click(object sender, EventArgs e) {
            frmMemberManagement frmMemberManagement = new frmMemberManagement();
            frmMemberManagement.Show();
        }

        private void btn_ProductManagement_Click(object sender, EventArgs e) {
            frmProductManagement frmProductManagement = new frmProductManagement();
            frmProductManagement.Show();
        }

        private void btn_OrderManagement_Click(object sender, EventArgs e) {
            frmOrderManagement frmOrderManagement = new frmOrderManagement();
            frmOrderManagement.Show();
        }

        private void frmGeneralManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSaleReport frm = new frmSaleReport();
            frm.Show();
        }
    }
}
