using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EnrollementApplication.Models
{
    //[Bind(Exclude ="StudentId")]
    public class Student : IValidatableObject
    {
        public virtual int StudentId { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [StringLength(50, ErrorMessage ="Your last name is too long.")]
        public virtual string LastName { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [StringLength(50, ErrorMessage = "Your first name is too long.")]
        public virtual string FirstName { get; set; }

        [MinimumAge(20)]
        public virtual int Age { get; set; }

        [Display(Name = "Address 1")]
        public virtual string Address1 { get; set; }

        [Display(Name = "Address 2")]
        public virtual string Address2 { get; set; }

        public virtual string City { get; set; }
        
        public virtual string Zipcode { get; set; }

        public virtual string State { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //Validation - Address2 cannot be same as Address1
            if (Address2 != null && Address2 == Address1)
            {
                //error
                yield return new ValidationResult("Address2 cannot be the same as Address1.", new[] { "Address2" });
            }

            //Validation - State must be 2 char code
            if (State.Length != 2)
            {
                //error
                yield return new ValidationResult("Enter a 2 digit State code", new[] { "State" });
            }

            //Validation - Zipcode is 5 digits long
            if (Zipcode.Length != 5)
            {
                //error
                yield return new ValidationResult("Enter a 5 digit Zipcode", new[] { "Zipcode" });
            }

        }
    }
}