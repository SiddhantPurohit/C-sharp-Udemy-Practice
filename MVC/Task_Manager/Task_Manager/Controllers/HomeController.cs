using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_Manager.Models;
using ControllerModels;
using DBCon.DBoperations;

namespace Task_Manager.Controllers
{
    public class HomeController : Controller
    {
        EmployeeRepo repo;
        TaskRepo trepo;
        public HomeController()
        {
            repo = new EmployeeRepo();
            trepo = new TaskRepo();
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Task_Uploader() //simply showing the View page
        {
            return View();
        }

        [HttpPost] //For getting Data from user
        public ActionResult Task_Uploader(TaskModel model) //Here the Data coming from the user gets stored in Taskmodel
        {
            if(ModelState.IsValid)
            {
                var id = trepo.AddTask(model); //The addtask method get called which get the data from user view comments in DBoperation for more detail
                return Redirect("/Home/Index");
            }

           
            return View();
        }
        
        [Authorize]
        public ActionResult Task_Viewer()
        {
            var Result = trepo.GetTask();
            return View(Result);
        }


        public ActionResult AboutAndContact()
        {
            return View();
        }

        public ActionResult Admin()
        {
            return View();
        }

        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost] 
        public ActionResult Create(EmployeeModel model)
        {
            if(ModelState.IsValid)
            {
                int id = repo.AddEmployee(model);
                return Redirect("/Home/Index");
            }
           
            return View();
        }

        public ActionResult ManagerLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ManagerLogin(ManagerPassword Mpass)
        {
            if(Mpass.UserName == "manager" && Mpass.Password == "manager123")
            {
                return Redirect("/Manager/Index");
            }
            return View(Mpass);
        }

    }
}