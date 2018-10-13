using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EnrollementApplication.Models
{
    //[Bind(Exclude ="StudentId")]
    public class Student
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

        
    }
}