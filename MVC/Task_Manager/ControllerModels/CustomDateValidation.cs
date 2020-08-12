using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControllerModels
{
    public class CustomDateValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            TaskModel tm = new TaskModel();
            if (tm.CompletionDate > DateTime.Now.AddDays(-3))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("You are late to submit your work");
        }
    }
}
