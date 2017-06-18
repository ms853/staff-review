using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace SytnerCollege.Models
{
    public class Student
    {
        //PrimaryKey for unique identify for every student. 
        public int ID { get; set; }  
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        
        //Added Data Annotation to explicitly specify the date format for both enrollent and dob.
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        [DataType(DataType.Date)] 
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; } //Date of Birth 

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
