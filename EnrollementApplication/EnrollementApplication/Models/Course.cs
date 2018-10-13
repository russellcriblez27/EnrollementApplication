using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EnrollementApplication.Models
{
    //[Bind(Exclude = "CourseId")]
    public class Course : IValidatableObject
    {
        [Display(Name = "Course ID")]
        public virtual int CourseId { get; set; }

        [Display(Name = "Course Title")]
        [Required(ErrorMessage ="You Must enter a Course Title.")]
        [StringLength(150, ErrorMessage ="Course title is too long. It must be 150 characters or less.")]
        public virtual string Title { get; set; }


        public virtual string Description { get; set; }

        [Display(Name = "Number of credits")]
        [Required]
        [Range(1,4, ErrorMessage ="Number of credits must be between 1 and 4.")]
        public virtual string Credits { get; set; }

        public virtual string InstructorName { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            int maxCredits = 4;
            int maxWords = 5;

            //validation 1 - Credits has to be 1-4

            if (int.Parse(Credits) > maxCredits)
            {
                //error
                yield return (new ValidationResult("Credits must be between 1 and 4", new[] { "Credits" }));
            }

            //validation 2 - Description 5 words or less
            if (Description.Split(' ').Length > maxWords)
            {
                //error
                yield return (new ValidationResult("Description must be 5 words or fewer.", new[] { "Description" }));
            }
        }
    }
}