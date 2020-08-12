using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clinic.Custom_Authentication;
using Clinic.DB_operations;
using Clinic.Models;


namespace Clinic.Controllers
{
    [DoctorAuthentication]
    public class DoctorController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewAppionment()
        {
            AppoinmentDB ADB = new AppoinmentDB();
            var Result = ADB.GetAppoinment();
            return View(Result);
        }

        public ActionResult AddDiagonostics()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDiagonostics(DiagonosticsInfo model)
        {
            DiagonosticsDB DDB = new DiagonosticsDB();
            int result = DDB.AddDiagonostics(model);
            return RedirectToAction("Index","Doctor");
        }
    }
}