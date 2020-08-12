using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Task_Manager.Models;

namespace Task_Manager.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Password passauth, string ReturnUrl)
        {
            
            if(Isvalid(passauth))
            {
                FormsAuthentication.SetAuthCookie(passauth.username , false);
                return Redirect(ReturnUrl);
            }
            else
            {
                return View(passauth);
            }
        }

        private bool Isvalid (Password passauth)
        {
            return (passauth.password == "admin123" && passauth.username == "admin");
        }
    }
}