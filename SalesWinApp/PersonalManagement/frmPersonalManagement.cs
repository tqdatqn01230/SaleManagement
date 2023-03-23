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
    public partial class frmPersonalManagement : Form
    { 
        MemberRepository _memberRepository = new MemberRepository();
        ProductRepository _productRepository = new ProductRepository();
        OrderRepository _orderRepository = new OrderRepository();
        IEnumerable<Order> _orderList = new List<Order>();
        OrderDetailRepository _orderDetailRepository = new OrderDetailRepository();
        IEnumerable<OrderDetail> _orderDetailList = new List<OrderDetail>();

        public frmPersonalManagement(Member _member) {
            InitializeComponent();
            this.AutoLoadDataInto_DGVOrder(_member);
        }

        private void btn_PersonalInfo_Click(object sender, EventArgs e) {
            var _memberEmail =label_Welcome.Text.Split(":");
            var _tempMember = _memberRepository.GetMemberByEmail(_memberEmail[1].Trim());
            frmMemberUpdate _frmMemberUpdate = new frmMemberUpdate(_tempMember);
            _frmMemberUpdate.ShowDialog();
        }

        private void dgv_Order_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var _tempOrder = _orderRepository.GetOrderById(Int32.Parse(dgv_Order.SelectedRows[0].Cells[0].Value.ToString()));
            this.LoadDataInto_DGVOrderDetail(_tempOrder);
        }
        private void AutoLoadDataInto_DGVOrder(Member _member) {
            label_Welcome.Text = $"Welcome Back: {_member.Email}";
            dgv_Order.Rows.Clear();
            _orderList = _orderRepository.FilterOrderListByMemberId(_member.MemberId);
            foreach (var _order in _orderList) {
                dgv_Order.Rows.Add(_order.OrderId, _order.OrderDate.ToShortDateString(), _order.RequiredDate.ToShortDateString(), _order.ShippedDate.ToShortDateString(), _order.Freight);
            }
        }
        private void LoadDataInto_DGVOrderDetail(Order _order) { 
            dgv_OrderDetail.Rows.Clear();
            _orderDetailList = _orderDetailRepository.FilterOrderDetailListByOrderId(_order.OrderId);
            foreach (var _orderDetail in _orderDetailList) {
                var _tempProduct = _productRepository.GetProductById(_orderDetail.ProductId);
                dgv_OrderDetail.Rows.Add(_tempProduct.ProductName, _tempProduct.UnitPrice, _orderDetail.Quantity, _orderDetail.Discount);
            }
        }
    }
}
