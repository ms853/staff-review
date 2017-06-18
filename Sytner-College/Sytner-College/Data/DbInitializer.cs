using System;
using System.Linq;
using SytnerCollege.Models;

namespace SytnerCollege.Data
{
    //This class is used to generate data for the database. 

    public class DbInitializer
    {
        public static void Initialize(CollegeContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01"), DOB=System.DateTime.Parse("1995-08-17")},
            new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01"), DOB=System.DateTime.Parse("1994-12-22")},
            new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01"), DOB=System.DateTime.Parse("1996-11-07")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01"), DOB = System.DateTime.Parse("1996-05-01")},
            new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01"), DOB = System.DateTime.Parse("1995-02-09")},
            new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01"), DOB = System.DateTime.Parse("1994-02-27")},
            new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01"), DOB = System.DateTime.Parse("1995-01-29")},
            new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01"), DOB = System.DateTime.Parse("1996-06-16")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3},
            new Course{CourseID=4022,Title="Economics",Credits=3},
            new Course{CourseID=4041,Title="Psychology",Credits=3},
            new Course{CourseID=1045,Title="Computer Science",Credits=4},
            new Course{CourseID=3141,Title="Computer Engineering",Credits=2},
            new Course{CourseID=2021,Title="Composition",Credits=3},
            new Course{CourseID=2042,Title="Literature",Credits=4},
            new Course{CourseID=2301,Title="Sociology",Credits=3},
            new Course{CourseID=1001,Title="Mathematics and Logic",Credits=4},
            new Course{CourseID=2000,Title="Mechanical Engineering",Credits=2}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.U},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.U},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=3,CourseID=3141},
            new Enrollment{StudentID=3,CourseID=2021},
            new Enrollment{StudentID=4,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.U},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=5,CourseID=1001,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=6,CourseID=2301, Grade=Grade.A},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            new Enrollment{StudentID=7,CourseID=2000,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    
}
}
