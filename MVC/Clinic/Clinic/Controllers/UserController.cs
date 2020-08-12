using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clinic.Models;
using Clinic.DB_operations;
using Clinic.Custom_Authentication;

namespace Clinic.Controllers
{
    [UserAuthentication]
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MakeAppoinment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MakeAppoinment(AppoinmentInfo model)
        {
            if (ModelState.IsValid)
            {
                AppoinmentDB adb = new AppoinmentDB();

                var result = adb.AddAppoinment(model);
                return RedirectToAction("Index", "Home");
            }
            return View();

        }

        public ActionResult ViewDignostics()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ViewDignostics(UserNameInfo model)
        {
            TempData["UserName"] = model.UserName;
            return RedirectToAction("Details", "User");
        }

        public ActionResult Details()
        {
            string UserNameRequested = Convert.ToString(TempData["UserName"]);
            using (var context = new Hospital_Simulation_DBEntities())
            {
                bool Isvalid = context.Diagonostics1.Any(x => x.UserName == UserNameRequested);
                if (Isvalid)
                {
                    DiagonosticsDB DDB = new DiagonosticsDB();
                    var Result = DDB.Detail(UserNameRequested);
                    return View(Result);
                }
            }

            return RedirectToAction("Error", "Shared");

        }
    }
}
