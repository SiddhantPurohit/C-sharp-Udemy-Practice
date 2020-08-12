using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestaurantSimulation.Models;

namespace RestaurantSimulation.ViewModel
{
    public class Orders
    {
        //public int OrderID { get; set; }
        public int PaymentTypeID { get; set; }
        public int CustomerID { get; set; }
        //public string OrderNumber { get; set; }
        //public System.DateTime OrderDate { get; set; }
        public decimal FinalTotal { get; set; }
        public IEnumerable<OrderDetails> orderDetails { get; set; }
        //public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}