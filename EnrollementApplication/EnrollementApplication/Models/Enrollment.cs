using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EnrollementApplication.Models
{
    [Bind(Exclude = "EnrollmentId")]
    public class Enrollment
    {
        public virtual int EnrollmentId { get; set; }


        public virtual int StudentId { get; set; }
        public virtual int CourseId { get; set; }

        [Required(ErrorMessage ="You must enter a gade.")]
        [RegularExpression("[A-F]", ErrorMessage ="Grade must be either A, B, C, D, E, or F.")]
        public virtual string Grade { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set;}
        public virtual bool IsActive { get; set; }

        [Display(Name ="Assigned Campus")]
        [Required(ErrorMessage ="You must enter an assigned campus.")]
        public virtual string AssignedCampus { get; set; }

        [Display(Name = "Enrolled in Semester")]
        [Required(ErrorMessage ="You must select an enrollment semester.")]
        public virtual string EnrollmentSemester { get; set; }

        [Display(Name = "Enrollment Year")]
        [Required(ErrorMessage ="Enrollment year required.")]
        [Range(2018, int.MaxValue, ErrorMessage ="Year of enrollment must be 2018 or later.")]
        public virtual int EnrollmentYear { get; set; }
    }
}