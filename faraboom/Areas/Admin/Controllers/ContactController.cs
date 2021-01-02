using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.AccessControl;
using System.Threading.Tasks;
using DataLayer.AdminEntities.Admin;
using DataLayer.Context;
using DataLayer.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ViewModels.AdminViewModel.Admin;

namespace Admin.Controllers {

    [Area ("Admin")]

    public class ContactController : Controller

    {

        private readonly ContextHampadco db;
        private readonly IWebHostEnvironment _env;
        public ContactController (ContextHampadco _db, IWebHostEnvironment env) {
            db = _db;
            _env = env;

        }
        public IActionResult Index () {

            return View ();
        }

        public IActionResult Add (Vm_info Q) {

            // Tbl_info A = new Tbl_info () {
            //     Phone = Q.Phone,
            //     PhonelocationN = Q.PhonelocationN,
            //     PhoneHome = Q.PhoneHome,
            //     PhoneNikatak = Q.PhoneNikatak,
            //     State = Q.State,
            //     City = Q.City,
            //     Postalcode = Q.Postalcode,
            //     homeaddress = Q.homeaddress,
            //     Locationaddress = Q.Locationaddress

            // };
            // db.Tbl_info.Add (A);
            // db.SaveChanges ();

            return RedirectToAction ("index");
        }
    }
}