using BussinessObject.Context;
using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class OrderDetailDAO
    {
        #region [ Using Singleton ]
        private static OrderDetailDAO instance = null;
        public static readonly object instanceLock = new object();
        public static OrderDetailDAO Instance {
            get {
                lock (instanceLock) {
                    if (instance == null) {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }
        #endregion

        #region [ Filter OrderDetail By - ]
        public IEnumerable<OrderDetail> FilterOrderDetailListByOrderId(int orderId) {
            var OrderDetailList = new List<OrderDetail>();
            try {
                using var context = new SaleManagementContext();
                OrderDetailList = context.OrderDetails.Where(x => x.OrderId == orderId).ToList(); 
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return OrderDetailList;
        }

        public IEnumerable<OrderDetail> FilterOrderDetailListByProductId(int productId) {
            var OrderDetailList = new List<OrderDetail>();
            try {
                using var context = new SaleManagementContext();
                OrderDetailList = context.OrderDetails.Where(x => x.ProductId == productId).ToList();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return OrderDetailList;
        }
        #endregion

        #region [ CRUD ]
        public IEnumerable<OrderDetail> GetOrderDetailList() {
            var OrderDetailList = new List<OrderDetail>();
            try {
                using var context = new SaleManagementContext();
                OrderDetailList = context.OrderDetails.ToList();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return OrderDetailList;
        }

        public OrderDetail GetOrderDetailById(int ProductId, int OrderId) {
            OrderDetail _tempOrderDetail = null;
            try {
                using var context = new SaleManagementContext();
                _tempOrderDetail = context.OrderDetails.FirstOrDefault(x => x.ProductId == ProductId && x.OrderId == OrderId);
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return _tempOrderDetail;
        }

        public void AddOrderDetail(OrderDetail _OrderDetail) {
            try {
                var _tempOrderDetail = this.GetOrderDetailById(_OrderDetail.ProductId, _OrderDetail.OrderId);
                if (_tempOrderDetail == null) {
                    using var context = new SaleManagementContext();
                    //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[User] ON");
                    //context.Database.OpenConnection();
                    context.OrderDetails.Add(_OrderDetail);
                    context.SaveChanges();
                } else {
                    
                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }

        public void UpdateOrderDetail(OrderDetail _OrderDetail) {
            try {
                OrderDetail tempOrderDetail = this.GetOrderDetailById(_OrderDetail.ProductId, _OrderDetail.OrderId);
                if (tempOrderDetail != null) {
                    using var context = new SaleManagementContext();
                    context.OrderDetails.Update(_OrderDetail);
                    context.SaveChanges();

                } else {
                    throw new Exception("The OrderDetail Id is not existed.");

                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }

        public void RemoveOrderDetail(OrderDetail _OrderDetail) {
            try {
                OrderDetail _tempOrderDetail = this.GetOrderDetailById(_OrderDetail.ProductId, _OrderDetail.OrderId);
                if (_tempOrderDetail != null) {
                    using var context = new SaleManagementContext();
                    context.OrderDetails.Remove(_tempOrderDetail);
                    context.SaveChanges();
                } else {
                    throw new Exception("The OrderDetail Id is not existed.");
                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }
        #endregion
    }
}
