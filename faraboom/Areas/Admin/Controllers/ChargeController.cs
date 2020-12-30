using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers {
    [Area ("Admin")]

    public class ChargeController : Controller {
        public IActionResult bill () {

            return View ();
        }

        public IActionResult charge () {

            return View ();
        }

        public IActionResult Invoicebill () {

            return View ();
        }

        public IActionResult Municipality () {

            return View ();
        }
    }
}