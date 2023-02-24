using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Assignment3
{
    public class Student : Person, IStudentService
    {
        public Student(DateTime birthDate, List<string> addresses, List<Course> courses) : base(birthDate, addresses)
        {
            Courses = courses;
        }

        public List<Course> Courses { get; set; }

        public double CalculateGPA() 
        {
            double totalGradePoints = 0;
            double totalCredits = 0;
            foreach (Course course in Courses)
            {
                double gradePoints = course.Grade;
                if (gradePoints > 0)
                {
                    totalGradePoints += gradePoints;
                    totalCredits += course.Credits;
                }
            }
            if (totalCredits == 0)
            {
                return 0;
            }
            return totalGradePoints / totalCredits;
        }
    }
}
