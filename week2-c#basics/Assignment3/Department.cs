using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Assignment3
{
    public class Department : IDepartmentService
    {
        public Instructor HeadInstructor { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Course> OfferedCourses { get; set; }

        // Constructor to initialize all properties
        public Department(Instructor headInstructor, decimal budget, DateTime startDate, DateTime endDate, List<Course> offeredCourses)
        {
            HeadInstructor = headInstructor;
            Budget = budget;
            StartDate = startDate;
            EndDate = endDate;
            OfferedCourses = offeredCourses;
        }

    }
}
