using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebBookshelf.Models;

namespace WebBookshelf.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Admin a)
        {
            var values = c.Admins.FirstOrDefault(x => x.UserName == a.UserName && x.Password == a.Password);
            if (values != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,a.UserName)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Default");
            }
            return View();
        }
    }
}
