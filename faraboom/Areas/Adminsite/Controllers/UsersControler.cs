using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using  faraboom.Models;
using DataLayer.Context;
using Microsoft.AspNetCore.Hosting;

namespace faraboom.Areas.Adminsite.Controllers
{
    
    public class  UsersController: BaseController
    {
        
            public UsersController(ContextHampadco _db,IWebHostEnvironment  env) :base(_db,env)
        {
        }
        public IActionResult Index()
        {
            if (err != null)
            {
                ViewBag.er = err;
                err = null;
            }
            ViewBag.list=db.Tbl_User.OrderByDescending(a=>a.Id).ToList();
            return View();
        }
         public IActionResult del(int id)
        {
            var selectdel = db.Tbl_User.Where(a => a.Id == id).SingleOrDefault();
            db.Tbl_User.Remove(selectdel);
            db.SaveChanges();
            err = "حذف با موفقیت انجام شد";
            return RedirectToAction("index");
        }

    }
}