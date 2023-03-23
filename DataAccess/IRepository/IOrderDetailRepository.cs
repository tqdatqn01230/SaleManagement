using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.IRepository
{
    public interface IOrderDetailRepository
    {
        public IEnumerable<OrderDetail> FilterOrderDetailListByOrderId(int orderId);
        public IEnumerable<OrderDetail> FilterOrderDetailListByProductId(int productId);
        public IEnumerable<OrderDetail> GetOrderDetailList();
        public OrderDetail GetOrderDetailById(int ProductId, int OrderId);
        public void AddOrderDetail(OrderDetail _OrderDetail);
        public void UpdateOrderDetail(OrderDetail _OrderDetail);
        public void RemoveOrderDetail(OrderDetail _OrderDetail);
    }
}
