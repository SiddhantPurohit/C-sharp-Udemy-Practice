using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinic.Models
{
    public class Logininfo
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AppoinmetID { get; set; }
    }
}