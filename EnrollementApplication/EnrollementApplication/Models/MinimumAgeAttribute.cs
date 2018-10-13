using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollementApplication.Models
{
    public class MinimumAgeAttribute: ValidationAttribute
    {
        readonly int min_age;

        public MinimumAgeAttribute(int minAge) : base("{0} does not meet the minimum age requirement!")
        {
            min_age = minAge;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                //if age < min age then error
                if ((int)value < min_age)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
            }

            return ValidationResult.Success;
            
        }

    }
}