using BussinessObject.Context;
using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.DAO
{
    public class OrderDAO
    {
        #region [ Using Singleton ]
        private static OrderDAO instance = null;
        public static readonly object instanceLock = new object();
        public static OrderDAO Instance {
            get {
                lock (instanceLock) {
                    if (instance == null) {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }
        #endregion

        #region [ Get OrderList By - ]
        // by member ID
        public IEnumerable<Order> FilterOrderListByMemberId(int MemberId) {
            var OrderList = new List<Order>();
            try {
                using var context = new SaleManagementContext();
                OrderList = context.Orders.Where(x => x.MemberId==MemberId).ToList(); 
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return OrderList;
        }
        // by from and to DateTime
        public IEnumerable<Order> FilterOrderListByDateTime(DateTime _from, DateTime _to) {
            var OrderList = new List<Order>();
            try {
                using var context = new SaleManagementContext();
                OrderList = context.Orders.Where(x =>  _from <= x.OrderDate && x.OrderDate <= _to).ToList().OrderByDescending(x => x.Freight).ToList();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return OrderList;
        }
        #endregion

        #region [ CRUD ]
        public IEnumerable<Order> GetOrderList() {
            var OrderList = new List<Order>();
            try {
                using var context = new SaleManagementContext();
                OrderList = context.Orders.ToList();
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return OrderList;
        }

        public Order GetOrderById(int id) {
            Order _tempOrder = null;
            try {
                using var context = new SaleManagementContext();
                _tempOrder = context.Orders.FirstOrDefault(x => x.OrderId == id);
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
            return _tempOrder;
        }

        public void AddOrder(Order _Order) {
            try {
                var _tempOrder = this.GetOrderById(_Order.OrderId);
                if (_tempOrder == null) {
                    using var context = new SaleManagementContext();
                    //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[User] ON");
                    //context.Database.OpenConnection();
                    context.Orders.Add(_Order);
                    context.SaveChanges();
                } else {
                    throw new Exception();
                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }

        public void UpdateOrder(Order _Order) {
            try {
                Order tempOrder = this.GetOrderById(_Order.OrderId);
                if (tempOrder != null) {
                    using var context = new SaleManagementContext();
                    context.Orders.Update(_Order);
                    context.SaveChanges();

                } else {
                    throw new Exception("The Order Id is not existed.");

                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }

        public void RemoveOrder(Order _Order) {
            try {
                Order _tempOrder = this.GetOrderById(_Order.OrderId);
                if (_tempOrder != null) {
                    using var context = new SaleManagementContext();
                    context.Orders.Remove(_tempOrder);
                    context.SaveChanges();
                } else {
                    throw new Exception("The Order Id is not existed.");
                }
            } catch (Exception ex) {
                throw new Exception(ex.ToString());
            }
        }
        #endregion
    }
}
