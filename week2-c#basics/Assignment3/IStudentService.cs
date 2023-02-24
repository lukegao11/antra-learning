using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Assignment3
{
    public interface IStudentService : IPersonService
    {
        List<Course> Courses { get; set; }
        double CalculateGPA();
    }
}
