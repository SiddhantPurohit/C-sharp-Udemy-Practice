using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Clinic.Models;

namespace Clinic.Custom_Validations
{
    public class CustomDateValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            AppoinmentInfo Ai = new AppoinmentInfo();
            if (Ai.DateOfAppoinment > DateTime.Now.AddDays(3))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("You can Only Book appoinment for 3 days after today. Put Date as YYYY-MM-DD");
        }
    }
}