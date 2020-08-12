using ECartSimulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECartSimulation.ViewModels;

namespace ECartSimulation.Controllers
{
    public class ShoppingController : Controller
    {
        ECartDBEntities objECartDBEnteties;
        public ShoppingController()
        {
            objECartDBEnteties = new ECartDBEntities();
        }
        public ActionResult Index()
        {
            IEnumerable<ShoppingViewModel> listofShoppingViewModel = (from objItem in objECartDBEnteties.Items
                                                                      join
                                                                      objCate in objECartDBEnteties.Categories
                                                                      on objItem.CategoryID equals objCate.CategoryID
                                                                      select new ShoppingViewModel
                                                                          {
                                                                              ImagePath = objItem.ImagePath,
                                                                              ItemName = objItem.ItemName,
                                                                              Description = objItem.Description,
                                                                              ItemPrice = objItem.ItemPrice,
                                                                              ItemID = objItem.ItemID,
                                                                              Category = objCate.CategoryName
                                                                          }
                                                                      ).ToList();
            return View(listofShoppingViewModel);
        }
    }
}