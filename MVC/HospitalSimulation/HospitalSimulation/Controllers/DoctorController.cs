using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HospitalSimulation.Customised_Authentication;
using HospitalSimulation.Models;

namespace HospitalSimulation.Controllers
{
    [DoctotorAuthentication]
    public class DoctorController : Controller
    {
        // GET: Doctor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewAppoinment()
        {
            var result = getAppoinments();

            return View(result);
        }

        public List<Appoinment> getAppoinments ()
        {
            using (var context = new Hospital_Simulation_DBEntities()) //connection to database
            {
                var result = context.Appoinments  //Query from a table
                    .Select(x => new Appoinment()
                    {
                        ID = x.ID,
                        PatientName = x.PatientName,
                        RepotedIssue = x.RepotedIssue,
                        AppoinmetDate = x.AppoinmetDate

                    }).ToList();

                return result;
            }
        }
 

    }
}