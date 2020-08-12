using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HospitalSimulation.Models;
using System.Web.Security;

namespace HospitalSimulation.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login model)
        {
            if (model.UserName == "Doctor" && model.Password == "Doctor")
            {
                FormsAuthentication.SetAuthCookie(model.UserName, false);
            }
            return RedirectToAction("Index","Doctor");
        }

        public ActionResult RLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RLogin(Login model)
        {
            if (model.UserName == "Reseption" && model.Password == "Reseption")
            {
                FormsAuthentication.SetAuthCookie(model.UserName, false);
            }
            return RedirectToAction("ReseptionHomePage", "Reseption");
        }
    }
}