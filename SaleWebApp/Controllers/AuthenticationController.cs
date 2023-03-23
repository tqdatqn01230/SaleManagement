using BussinessObject.Context;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Claims;

namespace SaleWebApp.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        private readonly SaleManagementContext _context;
        public AuthenticationController(SaleManagementContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            var a = _context.Members.FirstOrDefault(x => x.Email == email && x.Password == password);
            if (a == null)
            {
                ViewData["Message"] = "Wrong username or password";
                return View();
            }
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Role, "Customer"),
                new Claim(ClaimTypes.NameIdentifier, a.FullName),
               
            };
            var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authPro = new AuthenticationProperties()
            {
                IsPersistent = true,
            };
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimIdentity), authPro);
            HttpContext.Session.SetString("USER", JsonConvert.SerializeObject(a));
            return RedirectToAction("Index","Products");
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Session.Clear();
            return RedirectToAction("Index","Products");
        }
    }
}
