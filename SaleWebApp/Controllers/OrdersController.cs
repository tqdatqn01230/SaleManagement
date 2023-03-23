using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BussinessObject.Context;
using BussinessObject.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace SaleWebApp.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly SaleManagementContext _context;

        public OrdersController(SaleManagementContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            var user = JsonConvert.DeserializeObject<Member>(HttpContext.Session.GetString("USER"));
            var saleManagementContext = _context.Orders
                .Where(x => x.MemberId == user.MemberId)
                .Include(o => o.Member);
            return View(await saleManagementContext.ToListAsync());
        }

    }
}
