using RestaurantSimulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantSimulation.Repository
{
    public class CustomerRepository
    {
        private RestaurantDBEntities objrestaurantDBEntities;

        public CustomerRepository()
        {
            objrestaurantDBEntities = new RestaurantDBEntities();
        }

        public IEnumerable<SelectListItem> GetAllCustomers()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();

            objSelectListItems = (from obj in objrestaurantDBEntities.Customers
                                  select new SelectListItem()
                                  {
                                      Text = obj.CustomerName,
                                      Value = obj.CustomerID.ToString(),
                                      Selected = true
                                  }).ToList();

            return objSelectListItems;
        }
    }
}