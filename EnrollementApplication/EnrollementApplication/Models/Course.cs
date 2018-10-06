using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EnrollementApplication.Models
{
    [Bind(Exclude = "CourseId")]
    public class Course
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
        public virtual decimal Credits { get; set; }
    }
}