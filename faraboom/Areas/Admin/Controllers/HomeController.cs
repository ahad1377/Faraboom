using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using DataLayer.Context;
using Microsoft.AspNetCore.Hosting;
namespace Admin.Controllers
{
   [Area("Admin")]
   [Authorize]
    public class HomeController : Controller
    {
         private readonly ContextHampadco db;
        private readonly IHostingEnvironment _env;

        public HomeController (ContextHampadco _db, IHostingEnvironment env) {
            db = _db;
            _env = env;

        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
           

            return View();
        }
         public IActionResult Exit()
        {
            
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("index","home");
        }

         public IActionResult form()
        {
           

            return View();
        }


       
    }
}
