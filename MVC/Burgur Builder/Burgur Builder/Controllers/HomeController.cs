using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Burgur_Builder.Models;

namespace Burgur_Builder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Ingridients model)
        {
            TempData["Cheese"] = model.Cheese;
            TempData["Salad"] = model.Salad;
            TempData["Bacon"] = model.Bacon;
            TempData["Meat"] = model.Meat;

            return Redirect("/Home/DisplayBurgur");
        }

        public ActionResult DisplayBurgur ()
        {
            return View();
        }

        public ActionResult DisplayDynamicBurger()
        {
            return View();
        }

        public ActionResult ButtonPressedBurgur()
        {
            return View();
        }

    }
}