using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using faraboom.Models;
using DataLayer.Context;
using Microsoft.AspNetCore.Hosting;

namespace faraboom.Controllers
{
       public class PersenalController : BaseController
    {
        private readonly ContextHampadco db;
        private readonly IWebHostEnvironment env;

        ////////////////////////////////////////////////////type db
        public ContactController(ContextHampadco _db, IWebHostEnvironment env):base(_db,env)
        {
            db = _db;
            this.env = env;
        }

         
     
        public IActionResult Index()
        {
           return View();
        }

        public IActionResult Add()
        {
           return View();
        }
        
        

    }
}
