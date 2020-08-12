using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Online_Calculator.Models;
using Online_Calculator.Calculator_Operations;

namespace Online_Calculator.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Input input)
        {
            TempData["Input1"] = input.First_input;
            TempData["Input2"] = input.Second_input;
            TempData["Operation"] = input.Operation;
            return Redirect("/Home/DisplayOutput");
        }

        public ActionResult DisplayOutput()
        {

            int in1 = Convert.ToInt32( TempData["Input1"]);
            int in2 = Convert.ToInt32( TempData["Input2"]);
            string ope = Convert.ToString( TempData["Operation"]);


            operations op = new operations();
            var result = op.calculation(in1,in2,ope);

            ViewBag.output = result;
            return View();
        }
    }
}