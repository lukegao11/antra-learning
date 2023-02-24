using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Assignment3
{
    public interface IDepartmentService
    {
        Instructor HeadInstructor { get; set; }
        decimal Budget { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        List<Course> OfferedCourses { get; set; }
    }
}
