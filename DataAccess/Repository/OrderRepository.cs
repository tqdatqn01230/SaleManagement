using BussinessObject.Models;
using DataAccess.DAO;
using DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void AddOrder(Order _Order) => OrderDAO.Instance.AddOrder(_Order);

        public IEnumerable<Order> FilterOrderListByDateTime(DateTime _from, DateTime _to) => OrderDAO.Instance.FilterOrderListByDateTime(_from, _to);
        public IEnumerable<Order> FilterOrderListByMemberId(int MemberId) => OrderDAO.Instance.FilterOrderListByMemberId(MemberId);

        public Order GetOrderById(int id) => OrderDAO.Instance.GetOrderById(id);

        public IEnumerable<Order> GetOrderList() => OrderDAO.Instance.GetOrderList();

        public void RemoveOrder(Order _Order) => OrderDAO.Instance.RemoveOrder(_Order);

        public void UpdateOrder(Order _Order) => OrderDAO.Instance.UpdateOrder(_Order);
    }
}
