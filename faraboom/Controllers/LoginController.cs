using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DataLayer.AdminEntities.User;
using DataLayer.Context;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MimeKit;
using ViewModels.AdminViewModel.User;

namespace faraboom.Controllers {
    public class LoginController : Controller {
        public static string eror, massage, NewFileName;
        private readonly ContextHampadco db;
        private readonly IWebHostEnvironment _env;

        public LoginController (ContextHampadco _db, IWebHostEnvironment env) {
            db = _db;
            _env = env;

        }

        public IActionResult Index () {

            return View ();
        }
        public IActionResult Login () {
            if (eror != null) {
                // ViewBag.eror = eror;
                eror = null;

            }

            if (massage != null) {
                ViewBag.msg = massage;
                massage = null;

            }
            return View ();
        }
        public IActionResult Register () {

            return View ();
        }
        public IActionResult RegisterAgency () {

            return View ();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////AddRegisterAgency

        public async Task<IActionResult> AddReg (Vm_User VmReg) {

            //  if (db.Tbl_Registers.Any (a => a.CodeMeli == VmReg.CodeMeli)) {
            //     massage = "اطلاعات فردی با این کد ملی قبلا ثبت شده است";
            //     return RedirectToAction ("Login");

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////upload file
            string FileExtension1 = Path.GetExtension (VmReg.NameFile.FileName);
            NewFileName = String.Concat (Guid.NewGuid ().ToString (), FileExtension1);
            var path = $"{_env.WebRootPath}\\fileupload\\{NewFileName}";
            using (var stream = new FileStream (path, FileMode.Create)) {
                await VmReg.NameFile.CopyToAsync (stream);
            }
            //////////////////////////end upload file 

            Tb_User TblReg = new Tb_User () {
                NameFamily = VmReg.NameFamily,
                CodeMeli = VmReg.CodeMeli,
                PhoneUs = VmReg.PhoneUs,
                PasswordUs = VmReg.PasswordUs,
                EmailUS = VmReg.EmailUS,
                AddressUs = VmReg.AddressUs,
                ProfileImageUs = NewFileName,
                UserNameUs = VmReg.UserNameUs,
                state = false

            };
            db.Tbl_User.Add (TblReg);
            db.SaveChanges ();
            send(VmReg.NameFamily);
            massage = "اطلاعات شما با موفقیت ثبت شد لطفا ایمیل خود را چک فرمایید و منتظر تایید از سوی مدیریت باشید";
            return RedirectToAction ("Login");
        }
        ////////////////////////////////////////////////////////////////////////////////////////////AddRegisterAgency

        public IActionResult login_check (Vm_User us) {

            if (us.UserNameUs == "Admin") {
                var user = db.Tbl_User.Where (a => a.UserNameUs == "Admin" && a.PasswordUs == "nikatak5250").SingleOrDefault ();

                if (user != null) {

                    var claims = new List<Claim> () {
                    new Claim (ClaimTypes.NameIdentifier, user.Id.ToString ()),
                    new Claim (ClaimTypes.Name, "سعید عطایی")
                    };

                    var identity = new ClaimsIdentity (claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal (identity);

                    var properties = new AuthenticationProperties {
                        IsPersistent = true
                    };

                    HttpContext.SignInAsync (principal, properties);
                    return RedirectToAction ("index", "Home", new { area = "adminsite" });

                } else {
                    eror = "نام کاربری یا رمز عبور شما نادرست است";
                    return RedirectToAction ("Login");
                }

            } else {
                var user = db.Tbl_User.Where (a => a.UserNameUs == us.UserNameUs && a.PasswordUs == us.PasswordUs && a.state == true).SingleOrDefault ();

                if (user != null) {

                    var claims = new List<Claim> () {
                    new Claim (ClaimTypes.NameIdentifier, user.Id.ToString ()),
                    new Claim (ClaimTypes.Name, "admin")
                    };

                    var identity = new ClaimsIdentity (claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal (identity);

                    var properties = new AuthenticationProperties {
                        IsPersistent = true
                    };

                    HttpContext.SignInAsync (principal, properties);
                    return RedirectToAction ("index", "Home", new { area = "admin" });

                } else {
                    eror = "نام کاربری یا رمز عبور شما نادرست است";
                    return RedirectToAction ("Login");
                }
            }

        }

        public void send (String name) {
            MimeMessage message = new MimeMessage ();

            MailboxAddress from = new MailboxAddress ("نیکاتک",
                "info@nikatak.ir");
            message.From.Add (from);

            MailboxAddress to = new MailboxAddress ("User",
                "karim.nemati17@gmail.com");
            message.To.Add (to);

            message.Subject = "قرارداد سامانه هوشمند نیکاتک";

            var qtext=db.Tbl_Blog.Where(a=>a.Id==3)?.SingleOrDefault();

            BodyBuilder bodyBuilder = new BodyBuilder ();
            bodyBuilder.HtmlBody =  qtext.FullTextBlo.Replace("دوست",name);
            bodyBuilder.TextBody = "Hello World!";
            message.Body = bodyBuilder.ToMessageBody ();

            

            SmtpClient client = new SmtpClient ();
            client.Connect ("webmail.nikatak.ir", 465, true);
            client.Authenticate ("info@nikatak.ir", "12345@Iran");
            client.Send (message);
            client.Disconnect (true);
            client.Dispose ();

           
        }




        

       

    }
}