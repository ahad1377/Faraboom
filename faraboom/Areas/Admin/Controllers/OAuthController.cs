using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers {
    [Area ("Admin")]
    public class OAuthController : Controller {
        public async Task<IActionResult> Index () {

           

            return View ();
        }

        public async Task<IActionResult> Check (string code, string state) {

           


            return View ();
        }
    }
}