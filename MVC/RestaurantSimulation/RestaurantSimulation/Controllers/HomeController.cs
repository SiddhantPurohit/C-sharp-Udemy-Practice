using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantSimulation.ViewModel;
using RestaurantSimulation.Repository;
using RestaurantSimulation.Models;
using Orders = RestaurantSimulation.ViewModel.Orders;

namespace RestaurantSimulation.Controllers
{

    public class HomeController : Controller
    {
        private RestaurantDBEntities objrestaurantDBEntities;

        public HomeController()
        {
            objrestaurantDBEntities = new RestaurantDBEntities();
        }
        public ActionResult Index()
        {
            CustomerRepository objcustomerRepository = new CustomerRepository();
            ItemRepository objitemRepository = new ItemRepository();
            PaymentTypeRepository objpaymentTypeRepository = new PaymentTypeRepository();

            var objMultipleModel = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
                (objcustomerRepository.GetAllCustomers(), objitemRepository.GetAllItems(), objpaymentTypeRepository.GetAllPaymentType());

            return View(objMultipleModel);
        }

        [HttpGet]
        public JsonResult getItemUnitPrice(int itemID)
        {
            decimal UnitPrice = objrestaurantDBEntities.Items.Single(model => model.IremID == itemID).ItemPrice;
            return Json(UnitPrice, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Index(Orders orders)
        {
            return Json("data", JsonRequestBehavior.AllowGet);
        }
    }
}