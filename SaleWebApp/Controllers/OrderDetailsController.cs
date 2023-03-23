using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BussinessObject.Context;
using BussinessObject.Models;
using Microsoft.AspNetCore.Authorization;

namespace SaleWebApp.Controllers
{
    [Authorize]
    public class OrderDetailsController : Controller
    {
        private readonly SaleManagementContext _context;

        public OrderDetailsController(SaleManagementContext context)
        {
            _context = context;
        }

        // GET: OrderDetails
        public async Task<IActionResult> Index(int id)
        {
            var saleManagementContext = _context.OrderDetails
                .Where(x => x.OrderId == id)
                .Include(o => o.Order)
                .Include(o => o.Product);
            return View(await saleManagementContext.ToListAsync());
        }

        // GET: OrderDetails/Details/5
    }
}
