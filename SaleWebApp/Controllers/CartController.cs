using Microsoft.AspNetCore.Mvc;
using BussinessObject.Context;
using SaleWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using BussinessObject.Models;
using Microsoft.AspNetCore.Authorization;

namespace SaleWebApp.Controllers
{
    [Authorize(Roles = "Customer")]
    public class CartController : Controller
    {
        private readonly SaleManagementContext _context;
        
        public CartController(SaleManagementContext context)
        {
            _context = context;
        }
        public IActionResult Add(int ProductId)
        {
            var product = _context.Products
                .Include(x => x.Category)
                .FirstOrDefault(p => p.ProductId == ProductId);
            var cartStr = HttpContext.Session.GetString("cart");
            var cart = new List<CartItem>();
            if (cartStr == null)
            {
                //do nothing
            }
            else
            {
                cart = JsonConvert.DeserializeObject<List<CartItem>>(cartStr);
            }
            
            
            var a = cart.FirstOrDefault(x => x.ProductId == ProductId);
            if (a == null)
            {
                var cartItem = new CartItem()
                {
                    ProductId = product.ProductId,
                    ProductName = product.ProductName,
                    CategoryName = product.Category.CategoryName,
                    UnitPrice = product.UnitPrice,
                    Quantity = 1,
                    Weight = product.Weight,
                };
                cart.Add(cartItem);
            }
            else
            {
                a.Quantity++;
            }
            HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
            return RedirectToAction("Index", "Products");
        }
        public IActionResult Delete(int productId)
        {
            if (productId == 0)
            {
                return RedirectToAction("Index");
            }
            var cart = JsonConvert.DeserializeObject<List<CartItem>>(HttpContext.Session.GetString("cart"));
            var a = cart.First(x => x.ProductId == productId);
            cart.Remove(a);

            HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Update(int productId, int quantity)
        {
            var cart = JsonConvert.DeserializeObject<List<CartItem>>(HttpContext.Session.GetString("cart"));
            var a = cart.First(x => x.ProductId == productId);
            a.Quantity = quantity;
            HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Buy()
        {
            var cart = JsonConvert.DeserializeObject<List<CartItem>>(HttpContext.Session.GetString("cart"));
            foreach(var item in cart)
            {
                var product = _context.Products.FirstOrDefault(x => x.ProductId == item.ProductId);
                if(product != null)
                {
                    if (product.UnitsInStock < item.Quantity)
                    {
                        return RedirectToAction("Index", new { mess = "Product " + item.ProductName + " is not enough" });
                    }
                }
                else
                {
                    return RedirectToAction("Index", new {mess ="Product " + item.ProductName+ " is not exist anymore"});
                }
            }

            var order = new Order()
            {
                OrderId = createOrderId(),
                MemberId = getMemberId(),
                OrderDate = DateTime.Now,
                RequiredDate = DateTime.Now,
                ShippedDate = DateTime.Now,
                Freight = 0,
            };
            _context.Orders.Add(order);
            //await _context.SaveChangesAsync();
            foreach(var item in cart)
            {
                var a = _context.Products.FirstOrDefault(x => x.ProductId == item.ProductId);
                a.UnitsInStock -= item.Quantity;
                var detail = new OrderDetail()
                {
                    OrderId = order.OrderId,
                    ProductId = item.ProductId,
                    UnitPrice = item.UnitPrice,
                    Quantity = item.Quantity,
                    Discount = 0,
                };
                _context.Add(detail);
                await _context.SaveChangesAsync();
            }
            HttpContext.Session.Remove("cart");
            return RedirectToAction("Index", new {mess="Order Success"});
        }
        private int getMemberId()
        {
            var user = JsonConvert.DeserializeObject<Member>(HttpContext.Session.GetString("USER"));
            return user.MemberId;
        }
        private int createOrderId()
        {
            var index = _context.Orders
                .Max(x => x.OrderId) + 1;
            return index;
        }
        public IActionResult Index([FromQuery(Name ="mess")]string mess)
        {
            ViewData["mess"] = mess;
            var cartStr = HttpContext.Session.GetString("cart");
            if (cartStr != null)
            {
                var cart = JsonConvert.DeserializeObject<List<CartItem>>(cartStr);
                return View(cart);
            }
            else
            {
                return View(new List<CartItem>());
            }
        }
    }
}
