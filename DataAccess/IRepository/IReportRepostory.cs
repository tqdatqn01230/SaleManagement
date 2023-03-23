using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;
namespace DataAccess.IRepository
{
    public interface IReportRepostory
    {
        List<Order> GetOrderByDate(DateTime fromDate, DateTime toDate);

    }
}
