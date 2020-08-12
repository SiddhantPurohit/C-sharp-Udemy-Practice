using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinic.Models
{
    public class DiagonosticsInfo
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public int BloodSugar { get; set; }
        public int Temperature { get; set; }
        public int BloodPressure { get; set; }
    }
}