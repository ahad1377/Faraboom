using System.Security.Cryptography.X509Certificates;
namespace faraboom.Controllers {
    using System.Threading.Tasks;
    using Dto.Payment;
    using Microsoft.AspNetCore.Mvc;
    using ZarinPal.Class;
    using DataLayer.Context;
    using System.Linq;
    using faraboom.Models;
    using System;

    public class PayController : Controller {
        private readonly Payment _payment;
        private readonly Authority _authority;
        private readonly Transactions _transactions;
        public static string msg;
        private readonly ContextHampadco db;
        private static int sumshop;
        
        

        public PayController (ContextHampadco _db) {
            var expose = new Expose ();
            _payment = expose.CreatePayment ();
            _authority = expose.CreateAuthority ();
            _transactions = expose.CreateTransactions ();
            db=_db;
        }

        public IActionResult Index () {
            
            if (msg != null)
            {
                ViewBag.msg=msg;
                msg=null;
            }

            return View ();
        }
        //////////////////////////////////////////////////////////////////فرایند خرید
        public async Task<IActionResult> Request () {


          var qorder = db.Tbl_Order.Where (a => a.Id_user == Convert.ToInt32 (User.Identity.GetId ()) && a.State == "record").SingleOrDefault ();
           ViewBag.listp = db.Tbl_Factors.Where (a => a.Id_Order == qorder.Id).ToList ();
            int sum=0;
            foreach (var item in  ViewBag.listp)
            {
                sum=sum+item.Total_sum;
            }
            sumshop=sum;
              var quser=db.Tbl_User.Where(a=>a.Id==Convert.ToInt32 (User.Identity.GetId ()) ).SingleOrDefault();
            ////////////////////////////////////////////////////////////////////////////////link base
            var qlink=db.Tbl_Richats.SingleOrDefault();
            if (qlink.zarinpal != null &&  qlink.website != null)
            {
                
            var result = await _payment.Request (new DtoRequest () {
                    Mobile = quser.PhoneUs,
                    CallbackUrl =qlink.website+"/pay/validate",
                    Description = quser.UserNameUs,
                    Email = quser.EmailUS,
                    Amount = sumshop,
                    MerchantId = qlink.zarinpal
            }, ZarinPal.Class.Payment.Mode.zarinpal);
            return Redirect ($"https://zarinpal.com/pg/StartPay/{result.Authority}");
            }else
            {
                var result = await _payment.Request (new DtoRequest () {
                    Mobile = quser.PhoneUs,
                    CallbackUrl = qlink.website+"/pay/validate",
                    Description = quser.UserNameUs,
                    Email = quser.EmailUS,
                    Amount = sumshop,
                    MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX"
            }, ZarinPal.Class.Payment.Mode.sandbox);
            return Redirect ($"https://sandbox.zarinpal.com/pg/StartPay/{result.Authority}");
                
            }


            //////////////////////////////////////////////////////////////////////////////////
          

            
        }
        ////////////////////////////////////////////////////////////////////اعتبار سنجی
        public async Task<IActionResult> Validate (string authority, string status) {
             var qlink=db.Tbl_Richats.SingleOrDefault();
             if (qlink.zarinpal != null &&  qlink.website != null)
            {
                var verification = await _payment.Verification (new DtoVerification {
                Amount = sumshop,
                    MerchantId = qlink.zarinpal,
                    Authority = authority
                 }, Payment.Mode.zarinpal);
                 if (verification.Status == 100)
            {
              var qorder = db.Tbl_Order.Where (a => a.Id_user == Convert.ToInt32 (User.Identity.GetId ()) && a.State == "record").SingleOrDefault ();
              qorder.State="save";
              qorder.Date_Order=DateTime.UtcNow;
              qorder.Pay=sumshop.ToString();
              db.Tbl_Order.Update(qorder);
              db.SaveChanges();
              menu.order_count=0;

                msg="success";
                return RedirectToAction("list","cart");
                
            }else
            {
                msg="error";
                return RedirectToAction("order","cart");
            }
            }
            else
            {
               var verification = await _payment.Verification (new DtoVerification {
                Amount = sumshop,
                    MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                    Authority = authority
                 }, Payment.Mode.sandbox);
                 if (verification.Status == 100)
            {
              var qorder = db.Tbl_Order.Where (a => a.Id_user == Convert.ToInt32 (User.Identity.GetId ()) && a.State == "record").SingleOrDefault ();
              qorder.State="save";
              qorder.Date_Order=DateTime.UtcNow;
              qorder.Pay=sumshop.ToString();
              db.Tbl_Order.Update(qorder);
              db.SaveChanges();
              menu.order_count=0;

                msg="success";
                return RedirectToAction("list","cart");
                
            }else
            {
                msg="error";
                return RedirectToAction("order","cart");
            }

            }

           

            
            
            
        }

    }
}