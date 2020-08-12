using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Clinic.Custom_Validations;

namespace Clinic.Models
{
    public class AppoinmentInfo
    {
        public int ID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string ReportedIsuue { get; set; }
        public System.DateTime DateOfAppoinment { get; set; }
    }
}