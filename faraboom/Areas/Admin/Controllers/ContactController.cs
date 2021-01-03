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

            Tbl_info A = new Tbl_info () {

                    Nameper=Q.Nameper,
                    Familyper=Q.Familyper,
                    Fathernameper=Q.Fathernameper,
                    Nameen=Q.Nameen,
                    Familyen=Q.Familyen,
                    Fathernameen=Q.Fathernameen,
                    Place=Q.Place,
                    Serial=Q.Serial,
                    Religion=Q.Religion,
                    Email=Q.Email,
                    Datebirth=Q.Datebirth,
                    Gender=Q.Gender,
                    maritalstatus=Q.maritalstatus,
                    Bankname=Q.Bankname,
                    Bankcode=Q.Bankcode,
                    Branchname=Q.Branchname,
                    Accounttype=Q.Accounttype,
                    cardnumber=Q.cardnumber,
                    Shabanumber=Q.Shabanumber,
                    accountnumber=Q.accountnumber,
                    AccountName=Q.AccountName,
                    PostalcodeBank=Q.PostalcodeBank,
                    Address=Q.Address,
                    Phone=Q.Phone,
                    PhoneHome=Q.PhoneHome,
                    PhonelocationN=Q.PhonelocationN,
                    PhoneNikatak=Q.PhoneNikatak,
                    State=Q.State,
                    City=Q.City,
                    Postalcode=Q.Postalcode,
                    homeaddress=Q.homeaddress,
                    Locationaddress=Q.Locationaddress,
                    DiplomDate=Q.DiplomDate,
                    DiplomLocation=Q.DiplomLocation,
                    KardaniDate=Q.KardaniDate,
                    KardaniLocation=Q.KardaniLocation,
                    KarshenasiDate=Q.KarshenasiDate,
                    KarshenasiLocation=Q.KarshenasiLocation,
                    ArshadDate=Q.ArshadDate,
                    ArshadLocation=Q.ArshadLocation,
                    DoktoraDate=Q.DoktoraDate,
                    DoktoraLocation=Q.DoktoraLocation,
                    photos=Q.photos,
                    Nationalcard=Q.Nationalcard,
                    Nationalcardback=Q.Nationalcardback,
                    Certificate=Q.Certificate,
                    Shaba=Q.Shaba,
                    Degreeeducation=Q.Degreeeducation,
                    PostalcodeDoc=Q.PostalcodeDoc,
                    Document=Q.Document,
                    Badbackground=Q.Badbackground,
                    Receipt=Q.Receipt,
                    Companyname=Q.Companyname,
                    start=Q.start,
                    End=Q.End,
                    Typeactivity=Q.Typeactivity,
                    NationalCode=Q.NationalCode

            };
            db.Tbl_infos.Add (A);
            db.SaveChanges ();

            return RedirectToAction ("index");
        }
    }
}