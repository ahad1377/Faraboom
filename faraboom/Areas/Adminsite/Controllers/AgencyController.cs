using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.AdminEntities.Agency;
using DataLayer.Context;
using faraboom.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModels.AdminViewModel.Agency;

namespace faraboom.Areas.Adminsite.Controllers {
    public class AgencyController : BaseController {
        public AgencyController (ContextHampadco _db, IWebHostEnvironment env) : base (_db, env) { }
        public IActionResult Index () {
            if (err != null) {
                ViewBag.er = err;
                err = null;
            }
            return View ();
        }
        public IActionResult List () {
            if (err != null) {
                ViewBag.er = err;
                err = null;
            }
            ViewBag.list = db.Tbl_Agencie.ToList ();
            return View ();
        }

        public IActionResult del (int id) {
            var qdel = db.Tbl_Agencie.Where (add => add.Id == id).SingleOrDefault ();
            db.Tbl_Agencie.Remove (qdel);
            db.SaveChanges ();
            err = "حذف رکورد مورد نظر با موفقیت انجام شد";
            return RedirectToAction ("list");
        }

        public async Task<IActionResult> add (Vm_Agency ex) {
            ///////////////upload file
            string FileExtension1 = Path.GetExtension (ex.img.FileName);
            NewFileName = String.Concat (Guid.NewGuid ().ToString (), FileExtension1);
            var path = $"{_env.WebRootPath}\\fileupload\\{NewFileName}";
            using (var stream = new FileStream (path, FileMode.Create)) {

                await ex.img.CopyToAsync (stream);

            }
            //////////////////////////end upload file 
            Tb_Agency tb = new Tb_Agency () {

                ImageAg = NewFileName,
                NameAg = ex.NameAg,
                NamePersenAg = ex.NamePersenAg,
                TelAg = ex.TelAg,
                OfficetelAg = ex.OfficetelAg,
                LocationAg = ex.LocationAg,
                DescreptionAg = ex.DescreptionAg,
                Adress = ex.Adress,

                Language = ex.Language
            };
            db.Tbl_Agencie.Add (tb);
            db.SaveChanges ();
            err = "اطلاعات با موفقیت ثبت شد";
            return RedirectToAction ("index");

        }

    }
}