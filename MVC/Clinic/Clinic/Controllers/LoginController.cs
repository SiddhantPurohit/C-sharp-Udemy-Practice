using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clinic.Models;
using Clinic.DB_operations;
using System.Web.Security;

namespace Clinic.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(Logininfo model)
        {
            LoginDB logDB = new LoginDB();
            var result = logDB.AddLogin(model);
            return RedirectToAction("Login","Login");
        }

        public ActionResult Login ()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Logininfo model)
        {
            using (var context = new Hospital_Simulation_DBEntities())
            {
                bool Isvalid = context.UserLogins.Any(x => x.UserName == model.UserName && x.Password == model.Password && x.AppoinmetID == model.AppoinmetID);
                if (Isvalid)
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Index", "User");
                }
            }
            return View();
        }

        public ActionResult RLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RLogin(RLogin model)
        {
            
            if (model.UserName == "Res" && model.Password == "12345")
            {
                FormsAuthentication.SetAuthCookie(model.UserName, false);
                return RedirectToAction("Index", "Reseption");
            }

            return View();
        }

        public ActionResult DLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DLogin(Dlogin model)
        {

            if (model.UserName == "Doc" && model.Password == "12345")
            {
                FormsAuthentication.SetAuthCookie(model.UserName, false);
                return RedirectToAction("Index", "Doctor");
            }

            return View();
        }
    }
}