﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnrollementApplication.Models
{
    public class Course
    {
        public virtual int CourseId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Credits { get; set; }
    }
}