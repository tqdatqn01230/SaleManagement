using BussinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SaleWinApp
{
    public partial class frmOrderUpdate : Form
    {   ProductRepository _productRepository = new ProductRepository();
        IEnumerable<Product> _productList = new List<Product>();
        OrderDetailRepository _orderDetailRepository = new OrderDetailRepository();
        List<OrderDetail> _orderDetailList_New = new List<OrderDetail>();
        IEnumerable<OrderDetail> _orderDetailList_Old = new List<OrderDetail>();
        MemberRepository _memberRepository = new MemberRepository();
        IEnumerable<Member> _memberList= new List<Member>();
        OrderRepository _orderRepository = new OrderRepository();
        public frmOrderUpdate(Order _order) {
            InitializeComponent();
            this.AutoLoadDataInto_CB_Member();
            this.LoadDataInto_Inputs(_order);
            this.AutoLoadDataInto_CB_Product();
            this.Init_OderDetailList();
            this.AutoLoadDataInto_DGV_Product();
            this.Disable_Inputs_OrderDetail();
        }
        private void btn_AddOrderDetail_Click(object sender, EventArgs e) {
            if (btn_AddOrderDetail.Text.Contains("Add")) {
                this.Enable_Inputs_OrderDetail();
                btn_CancelOrderDetail.Enabled = true;
                btn_AddOrderDetail.Text = "Save Order Detail";
            } else {
                if (cb_Product.SelectedIndex < 0
                    || mtb_Quantity.Text.Equals("")) {
                    MessageBox.Show("Invalud Input.");
                } else {
                    var _tempProduct = (Product)cb_Product.SelectedItem;
                    int i = 0;
                    foreach (var _orderDetail in _orderDetailList_New) {
                        if (_orderDetail.ProductId == _tempProduct.ProductId) {
                            i = 1;
                            break;
                        } else {
                            i = 2;
                        }
                    }
                    if (i==1) {
                        var _orderDetail = _orderDetailList_New.Find(x => x.ProductId == _tempProduct.ProductId);
                            // _orderDetailRepository.GetOrderDetailById(_tempProduct.ProductId, Int32.Parse(mTB_OrderId.Text.ToString()));
                        int j =  Int32.Parse(mtb_Quantity.Text.Trim());
                        int result = _orderDetail.Quantity + j;
                        _orderDetail.Quantity = result;
                        this.AutoLoadDataInto_DGV_Product();
                    } else {
                        var _tempOrderDetail = new OrderDetail();
                        _tempOrderDetail.ProductId = _tempProduct.ProductId;
                        _tempOrderDetail.OrderId = Int32.Parse(mTB_OrderId.Text.Trim().ToString());
                        _tempOrderDetail.UnitPrice = _tempProduct.UnitPrice;
                        _tempOrderDetail.Quantity = Int32.Parse(mtb_Quantity.Text.Trim());
                        if (mtb_Discount.Text.Equals("")) {
                            _tempOrderDetail.Discount = (double)0;
                        } else {
                            _tempOrderDetail.Discount = double.Parse(mtb_Discount.Text.Trim());
                        }
                        this.Add_DGV_OrderDetailRow(_tempOrderDetail);
                    }

                        btn_CancelOrderDetail.Enabled = false;                
                        btn_AddOrderDetail.Text = "Add an Order Detail";
                        this.Disable_Inputs_OrderDetail();
                        this.Clear_Inputs_OrderDetail();
                    
                }
            }
        }

        private void btn_CancelOrderDetail_Click(object sender, EventArgs e) {
            this.Clear_Inputs_OrderDetail();
            this.Disable_Inputs_OrderDetail();
            btn_CancelOrderDetail.Enabled = false;
            btn_AddOrderDetail.Text = "Add an Order Detail";
        }

        private void btn_DeleteOrderDetail_Click(object sender, EventArgs e) {
            DialogResult _dialogResult;
            _dialogResult = MessageBox.Show("Do you really want to delete chosen Order Detail?", "Management", (MessageBoxButtons)MessageBoxDefaultButton.Button1);
            if (_dialogResult == DialogResult.OK) {
                foreach (var item in dgv_OrderDetails.SelectedRows) {
                    _orderDetailList_New.RemoveAt(dgv_OrderDetails.CurrentCell.RowIndex);
                }
                this.AutoLoadDataInto_DGV_Product();
                MessageBox.Show("Deleted the chosen order Detail.");
            }
        }

        private void btn_Save_Click(object sender, EventArgs e) {
            if (cB_Member.SelectedIndex < 0
                || mTB_Freight.Text.Equals("")) {
                MessageBox.Show("Invalid Input.");
            } else if (_orderDetailList_New.Count <1) {
                MessageBox.Show("Order Detail List must not be empty.");
            }else{
                // save Order first
                var _tempOrder = _orderRepository.GetOrderById(Int32.Parse(mTB_OrderId.Text.ToString()));
                var _tempMember = (Member)cB_Member.SelectedItem;
                _tempOrder.MemberId = _tempMember.MemberId;
                _tempOrder.OrderDate = DateTime.Parse(dTP_OrderDate.Value.ToString());
                _tempOrder.RequiredDate = DateTime.Parse(dTP_RequiredDate.Value.ToString());
                _tempOrder.ShippedDate = DateTime.Parse(dTP_ShippedDate.Value.ToString());
                _tempOrder.Freight = decimal.Parse(mTB_Freight.Text);
                _orderRepository.UpdateOrder(_tempOrder);

                // save Order Detail List
                var _tempOrderDetailList = _orderDetailList_New.Except(_orderDetailList_Old);
                foreach (var _tempOrderDetail in _tempOrderDetailList) {
                    _orderDetailRepository.AddOrderDetail(_tempOrderDetail);
                }
                this.Close();
                MessageBox.Show("Updated successfully.");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e) {
            //cB_Member.Text = "";
            var _tempOrder = _orderRepository.GetOrderById(Int32.Parse(mTB_OrderId.Text.ToString()));
            this.LoadDataInto_Inputs(_tempOrder);
        }

        private void cB_Member_TextChanged(object sender, EventArgs e) {
            _memberList = _memberRepository.FilterMemberByString(cB_Member.Text);
            this.LoadDataInto_CB_Member(_memberList);
        }
        #region [ Load Data functions ]
        
        private void cb_Product_SelectedIndexChanged(object sender, EventArgs e) {
            if (cb_Product.SelectedIndex > -1) {
                var _tempProduct = (Product)cb_Product.SelectedItem;
                tb_UnitPrice.Text = _tempProduct.UnitPrice.ToString();
            } else {
                tb_UnitPrice.Clear();
            }
        }
        private void AutoLoadDataInto_DGV_Product() {
            dgv_OrderDetails.Rows.Clear();
            foreach (var _orderDetail in _orderDetailList_New) {
                var tempProduct = _productRepository.GetProductById(_orderDetail.ProductId);
                dgv_OrderDetails.Rows.Add(tempProduct, _orderDetail.UnitPrice, _orderDetail.Quantity, _orderDetail.Discount);
            }
        }

        public void Add_DGV_OrderDetailRow(OrderDetail _orderDetail) {
            _orderDetailList_New.Add(_orderDetail);
            this.AutoLoadDataInto_DGV_Product();
        }
        public void LoadDataInto_Inputs(Order _order) {
            var index = GetMemberIndex(_order);
            mTB_OrderId.Text = _order.OrderId.ToString();
            cB_Member.SelectedIndex = index;
            dTP_OrderDate.Text = _order.OrderDate.ToString();
            dTP_RequiredDate.Text = _order.RequiredDate.ToString();
            dTP_ShippedDate.Text = _order.ShippedDate.ToString();
            var _tempFreightString = _order.Freight.ToString();
            mTB_Freight.Text = _tempFreightString.Remove(_tempFreightString.Length-5);
        }

        public void AutoLoadDataInto_CB_Member() {
            _memberList = _memberRepository.GetMemberList();
            this.LoadDataInto_CB_Member(_memberList);
        }
        public void LoadDataInto_CB_Member(IEnumerable<Member> _memberList) {
            cB_Member.Items.Clear();
            foreach (var member in _memberList) { 
                cB_Member.Items.Add(member);
            }
        }
        public int GetMemberIndex(Order _order) {
            int count = 0;
            var _tempMember = _memberRepository.GetMemberById((int)_order.MemberId);
            _memberList = _memberRepository.GetMemberList();
            foreach (var member in _memberList) {
                if (_tempMember.MemberId == member.MemberId) {
                    return count;
                } else {
                    count++;
                }
            } return count;
        }
        public void AutoLoadDataInto_CB_Product() {
            _productList = _productRepository.GetProductList();
            foreach (var _product in _productList) {
                cb_Product.Items.Add(_product);
            }
        }
        #endregion

        #region [ input functinos ]
        public void Disable_Inputs_OrderDetail() {
            cb_Product.Enabled = false;
            mtb_Discount.Enabled = false;
            mtb_Quantity.Enabled = false;
        }

        public void Enable_Inputs_OrderDetail() {
            cb_Product.Enabled = true;
            mtb_Discount.Enabled = true;
            mtb_Quantity.Enabled = true;
        }
        public void Clear_Inputs_OrderDetail() {
            cb_Product.SelectedIndex = -1;
            mtb_Discount.Clear();
            mtb_Quantity.Clear();
        }
        #endregion

        private void Init_OderDetailList() {
            _orderDetailList_Old = _orderDetailRepository.FilterOrderDetailListByOrderId(Int32.Parse(mTB_OrderId.Text.Trim()));
            _orderDetailList_New.AddRange(_orderDetailList_Old);
        }

        private void frmOrderUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
