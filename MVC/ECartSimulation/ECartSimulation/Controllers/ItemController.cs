using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECartSimulation.Models;
using ECartSimulation.ViewModels;

namespace ECartSimulation.Controllers
{
    public class ItemController : Controller
    {
        ECartDBEntities objECartDBEnteties;
        public ItemController()
        {
            objECartDBEnteties = new ECartDBEntities();
        }
        // GET: Item
        public ActionResult Index()
        {
            ItemViewModel objItemViewModel = new ItemViewModel();
            objItemViewModel.CategorySelectListItems = (from objCat in objECartDBEnteties.Categories
                                                        select new SelectListItem()
                                                        { 
                                                            Text = objCat.CategoryName,
                                                            Value = objCat.CategoryID.ToString(),
                                                            Selected = true
                                                        });
            return View(objItemViewModel);
        }

        [HttpPost]
        public JsonResult Index(ItemViewModel objItemViewModel)
        {
            string NewImage = Guid.NewGuid() + Path.GetExtension(objItemViewModel.ImagePath.FileName);
            objItemViewModel.ImagePath.SaveAs(Server.MapPath("~/Images/"+ NewImage));

            Item objItem = new Item();
            objItem.ImagePath = "~/Images/" + NewImage;
            objItem.CategoryID = objItemViewModel.CategoryID;
            objItem.Description = objItemViewModel.Description;
            objItem.ItemCode = objItemViewModel.ItemCode;
            objItem.ItemName = objItemViewModel.ItemName;
            objItem.ItemID = Guid.NewGuid();
            objItem.ItemPrice = objItemViewModel.ItemPrice;

            objECartDBEnteties.Items.Add(objItem);
            objECartDBEnteties.SaveChanges();

            return Json(new { Success = true, Message = "Item Added successfully" }, JsonRequestBehavior.AllowGet);
        }
    }
}