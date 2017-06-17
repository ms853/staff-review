using System;
using System.Collections.Generic;

namespace SytnerCollege.Models
{
    public class Student
    {
        public int ID { get; set; } //Student ID which uniquely identifies each student. 
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public DateTime DOB { get; set; } //Date of Birth 

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
