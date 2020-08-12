using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControllerModels
{
    public class ManagerTaskModel
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Task { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string EmployeeID { get; set; }
    }
}
