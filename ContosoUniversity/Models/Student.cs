﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // navigation property
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public virtual Career Carrera { get; set; }

    }
}