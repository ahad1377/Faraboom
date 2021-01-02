using System.Security.Cryptography.X509Certificates;
namespace faraboom.Controllers {
    using System.Linq;
    using System.Threading.Tasks;
    using System;
    using DataLayer.Context;
    using Dto.Payment;
    using faraboom.Models;
    using Microsoft.AspNetCore.Mvc;
    using ZarinPal.Class;

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
            db = _db;
        }

        public IActionResult Index () {

            if (msg != null) {
                ViewBag.msg = msg;
                msg = null;
            }

            return View ();
        }
        //////////////////////////////////////////////////////////////////فرایند خرید
        public async Task<IActionResult> Request (int id) {
            int Price;
            if (id == 6) {
                Price == 500000000;
            } else {
                Price == 400000000;

            }

            if (qlink.zarinpal != null && qlink.website != null) {

                var result = await _payment.Request (new DtoRequest () {
                    Mobile ="09149501938",
                        CallbackUrl = "https://localhost:5001/" + "/pay/validate",
                        Description = "Test",
                        Email = "karim.nemati17@gmail.com",
                        Amount = Price,
                        MerchantId = qlink.zarinpal
                }, ZarinPal.Class.Payment.Mode.zarinpal);
                return Redirect ($"https://zarinpal.com/pg/StartPay/{result.Authority}");
            } else {
                var result = await _payment.Request (new DtoRequest () {
                    Mobile = "09149501938",
                        CallbackUrl =  "https://localhost:5001/" + "/pay/validate",
                        Description ="Test",
                        Email ="karim.nemati17@gmail.com",
                        Amount = Price,
                        MerchantId = "ab99ecd5-bc8a-402f-8ead-b8dca3ed0e35"
                }, ZarinPal.Class.Payment.Mode.sandbox);
                return Redirect ($"https://sandbox.zarinpal.com/pg/StartPay/{result.Authority}");
            }
            //////////////////////////////////////////////////////////////////////////////////
        }
        ////////////////////////////////////////////////////////////////////اعتبار سنجی
        public async Task<IActionResult> Validate (string authority, string status) {
            var qlink = db.Tbl_Richats.SingleOrDefault ();
            if (qlink.zarinpal != null && qlink.website != null) {
                var verification = await _payment.Verification (new DtoVerification {
                    Amount = sumshop,
                        MerchantId = qlink.zarinpal,
                        Authority = authority
                }, Payment.Mode.zarinpal);
                if (verification.Status == 100) {
                    var qorder = db.Tbl_Order.Where (a => a.Id_user == Convert.ToInt32 (User.Identity.GetId ()) && a.State == "record").SingleOrDefault ();
                    qorder.State = "save";
                    qorder.Date_Order = DateTime.UtcNow;
                    qorder.Pay = sumshop.ToString ();
                    db.Tbl_Order.Update (qorder);
                    db.SaveChanges ();
                    menu.order_count = 0;

                    msg = "success";
                    return RedirectToAction ("list", "cart");

                } else {
                    msg = "error";
                    return RedirectToAction ("order", "cart");
                }
            } else {
                var verification = await _payment.Verification (new DtoVerification {
                    Amount = sumshop,
                        MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                        Authority = authority
                }, Payment.Mode.sandbox);
                if (verification.Status == 100) {
                    var qorder = db.Tbl_Order.Where (a => a.Id_user == Convert.ToInt32 (User.Identity.GetId ()) && a.State == "record").SingleOrDefault ();
                    qorder.State = "save";
                    qorder.Date_Order = DateTime.UtcNow;
                    qorder.Pay = sumshop.ToString ();
                    db.Tbl_Order.Update (qorder);
                    db.SaveChanges ();
                    menu.order_count = 0;

                    msg = "success";
                    return RedirectToAction ("list", "cart");

                } else {
                    msg = "error";
                    return RedirectToAction ("order", "cart");
                }

            }

        }

    }
}