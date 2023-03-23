using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;
using DataAccess.IRepository;
using BussinessObject.Context;
using Microsoft.EntityFrameworkCore;
namespace DataAccess.Repository
{
    public class ReportRepository : IReportRepostory
    {
        public List<Order> GetOrderByDate(DateTime fromDate, DateTime toDate)
        {
            using (SaleManagementContext context = new SaleManagementContext())
            {
                return context.Orders.Where(x=> x.OrderDate>= fromDate 
                    && x.OrderDate<=toDate)
                    .Include(x=> x.OrderDetails)
                    .Include(x=> x.Member)
                    .ToList();
            }
        }
    }
}
