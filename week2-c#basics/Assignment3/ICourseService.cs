using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Assignment3
{
    public interface ICourseService
    {
        List<Student> EnrolledStudents { get; set; }
        Grade GetGrade(Student student);
    }
}
