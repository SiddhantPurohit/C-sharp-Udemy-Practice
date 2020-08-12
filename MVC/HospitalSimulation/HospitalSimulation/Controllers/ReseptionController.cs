using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HospitalSimulation.Customised_Authentication;

namespace HospitalSimulation.Controllers
{
    [ReseptionAuthentication]
    public class ReseptionController : Controller
    {
        // GET: Reseption
        public ActionResult ReseptionHomePage()
        {
            return View();
        }

        public ActionResult AddAppoinment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAppoinment(Appoinment model)
        {
            using ( var context = new Hospital_Simulation_DBEntities())
            {
                context.Appoinments.Add(model);
                context.SaveChanges();
            }
            return RedirectToAction("Reseption", "ReseptionHomePage");
        }
    }
}