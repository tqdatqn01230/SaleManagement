using BussinessObject.Models;
using DataAccess.DAO;
using DataAccess.IRepository;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void AddOrderDetail(OrderDetail _OrderDetail) => OrderDetailDAO.Instance.AddOrderDetail(_OrderDetail);

        public IEnumerable<OrderDetail> FilterOrderDetailListByOrderId(int orderId) => OrderDetailDAO.Instance.FilterOrderDetailListByOrderId(orderId);

        public IEnumerable<OrderDetail> FilterOrderDetailListByProductId(int productId) => OrderDetailDAO.Instance.FilterOrderDetailListByProductId(productId);

        public OrderDetail GetOrderDetailById(int ProductId, int OrderId) => OrderDetailDAO.Instance.GetOrderDetailById(ProductId, OrderId);

        public IEnumerable<OrderDetail> GetOrderDetailList() => OrderDetailDAO.Instance.GetOrderDetailList();

        public void RemoveOrderDetail(OrderDetail _OrderDetail) => OrderDetailDAO.Instance.RemoveOrderDetail(_OrderDetail);

        public void UpdateOrderDetail(OrderDetail _OrderDetail) => OrderDetailDAO.Instance.UpdateOrderDetail(_OrderDetail);
    }
}
