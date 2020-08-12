using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestaurantSimulation.Models;
using System.Web.Mvc;

namespace RestaurantSimulation.Repository
{
    public class PaymentTypeRepository
    {
        private RestaurantDBEntities objrestaurantDBEntities;

        public PaymentTypeRepository()
        {
            objrestaurantDBEntities = new RestaurantDBEntities();
        }

        public IEnumerable<SelectListItem> GetAllPaymentType()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (from obj in objrestaurantDBEntities.PaymentsTypes
                                  select new SelectListItem()
                                  {
                                      Text = obj.PaymentTypeName,
                                      Value = obj.PaymentTypeID.ToString(),
                                      Selected = true
                                  }).ToList();

            return objSelectListItems;
        }
    }
}