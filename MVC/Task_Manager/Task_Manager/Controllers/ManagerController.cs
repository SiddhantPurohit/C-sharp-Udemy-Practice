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
    public class ManagerController : Controller
    {
        ManagerRepo mrepo;
        ManagerTaskRepo mtrepo;
        TaskRepo trepo;

        public ManagerController()
        {
            mrepo = new ManagerRepo();
            mtrepo = new ManagerTaskRepo();
            trepo = new TaskRepo();
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UploadTask()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadTask(ManagerTaskModel model)
        {
            if(ModelState.IsValid)
            {
                mtrepo.AddTask(model);
                return Redirect("/Manager/Index");
            }
            return View();

        }

        public ActionResult ViewEmployeTask ()
        {
            var result = trepo.GetTask();
            return View(result);
        }

        public ActionResult AddManager ()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddManager(ManagerModel Mmodel)
        {
            if(ModelState.IsValid)
            {
                var id = mrepo.AddManager(Mmodel);
                return Redirect("/Home/Index");
            }

            return View();
        }

        public ActionResult ViewManagerTask()
        {
            var result= mtrepo.GetManagerTask();
            return View(result);
        }

        
        public ActionResult Delete(int id)
        {
            trepo.DeleteTask(id);

            return RedirectToAction("/ViewEmployeTask");
        }

        public ActionResult Details (int id)
        {
            var result = trepo.Detail(id);

            return View(result);
        }
    }
}