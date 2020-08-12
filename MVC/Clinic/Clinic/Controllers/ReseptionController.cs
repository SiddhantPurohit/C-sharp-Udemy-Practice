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
    [ReseptionAuthentication]
    public class ReseptionController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewAppoinments()
        {
            AppoinmentDB ADB = new AppoinmentDB();
            var result = ADB.GetAppoinment();
            return View(result);
        }

        public ActionResult AddAppoinment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAppoinment(AppoinmentInfo model)
        {
            AppoinmentDB ADB = new AppoinmentDB();
            int result = ADB.AddAppoinment(model);
            return RedirectToAction("Index","Reseption");
        }

        public ActionResult Delete(int ID)
        {
            AppoinmentDB ADB = new AppoinmentDB();
            ADB.DeleteAppoinment(ID);
            return RedirectToAction("ViewAppoinments", "Reseption");
        }

        public ActionResult Details (int ID)
        {
            AppoinmentDB ADB = new AppoinmentDB();
            var Result = ADB.Detail(ID);

            return View(Result);
        }

        public ActionResult Edit(int ID)
        {
            AppoinmentDB ADB = new AppoinmentDB();
            var Result = ADB.Detail(ID);

            return View(Result);
        }

        [HttpPost]
        public ActionResult Edit(AppoinmentInfo model)
        {
            AppoinmentDB ADB = new AppoinmentDB();
            ADB.Edit(model.ID , model);

            return RedirectToAction("ViewAppoinments", "Reseption");
        }
    }
}