﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnrollementApplication.Models
{
    public class Enrollment
    {
        public virtual int EnrollmentId { get; set; }
        public virtual int StudentId { get; set; }
        public virtual int CourseId { get; set; }
        public virtual char Grade { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set;}
    }
}