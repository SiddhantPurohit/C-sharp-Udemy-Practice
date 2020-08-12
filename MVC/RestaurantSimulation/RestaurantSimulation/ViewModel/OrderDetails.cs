using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantSimulation.ViewModel
{
    public class OrderDetails
    {
        //public int OrderDetailID { get; set; }
        //public int OrderID { get; set; }
        public int ItemID { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }

        public virtual Orders Order { get; set; }
    }
}