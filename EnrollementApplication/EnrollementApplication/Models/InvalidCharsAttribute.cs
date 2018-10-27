using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollementApplication.Models
{
    public class InvalidCharsAttribute : ValidationAttribute
    {
        readonly char[] inValid;
        

        public InvalidCharsAttribute(string inValidChars) : base("{0} contains unacceptable characters!")
        {
            inValid = inValidChars.ToCharArray();

        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                for (int i = 0; i < inValid.Length; i++)
                {
                    if (value.ToString().Contains(inValid[i]))
                    {
                        //error
                        var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                        return new ValidationResult(errorMessage);
                    }

                }
                return ValidationResult.Success;
            }
            else return ValidationResult.Success;

        }
    }
}