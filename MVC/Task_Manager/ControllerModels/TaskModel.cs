using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControllerModels
{
    public class TaskModel
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Task1 { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string EmployeeID { get; set; }
        [Required]
        [CustomDateValidation]
        public DateTime CompletionDate { get; set; }
        
    }
}
