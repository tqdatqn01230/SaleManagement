using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;
using DataAccess.IRepository;
using BussinessObject.Models;
namespace SalesWinApp.Sale_Report
{
    public partial class frmSaleReport : Form
    {
        private IReportRepostory reportRepostory;
        public frmSaleReport()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmSaleReport_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            reportRepostory = new ReportRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePicker1.Value.Date.AddHours(0);
            DateTime toDate = dateTimePicker2.Value.Date.AddHours(24);
            if (fromDate > toDate)
            {
                label5.ForeColor = Color.Red;
                label5.Text = "To date must be after from Date, This's not TENET of Nolan";
                return;
            }
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Member", "Member");
            dataGridView1.Columns.Add("OrderDate", "OrderDate");
            dataGridView1.Columns.Add("RequiredDate", "RequiredDate");
            dataGridView1.Columns.Add("ShippedDate", "ShippedDate");
            dataGridView1.Columns.Add("Freight", "Freight");

            dataGridView1.Columns["Id"].DataPropertyName = "OrderId";
            dataGridView1.Columns["Member"].DataPropertyName = "Member.Email";
            dataGridView1.Columns["OrderDate"].DataPropertyName = "OrderDate";
            dataGridView1.Columns["RequiredDate"].DataPropertyName = "RequiredDate";
            dataGridView1.Columns["ShippedDate"].DataPropertyName = "ShippedDate";
            dataGridView1.Columns["Freight"].DataPropertyName = "Freight";
            List<Order> orders= reportRepostory.GetOrderByDate(fromDate, toDate);
            dataGridView1.DataSource = orders;

            int count = 0;
            decimal total = 0;

            foreach(Order order in orders)
            {
                
                total += (decimal) order.Freight;
                foreach(OrderDetail orderDetail in order.OrderDetails)
                {
                    count += orderDetail.Quantity;
                    total += orderDetail.UnitPrice * orderDetail.Quantity * (decimal)(1 - orderDetail.Discount / 100);
                }
            }
            textBox1.Text = ((int)total).ToString();
            textBox2.Text = count.ToString();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Order order = dataGridView1.Rows[e.RowIndex].DataBoundItem as Order;
            dataGridView1.Rows[e.RowIndex].Cells["Member"].Value = order.Member.Email;
        }
    }
}
