using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Assignment3
{
    public interface IInstructorService : IPersonService
    {
        Department Department { get; set; }
        bool IsDepartmentHead { get; set; }
        decimal CalculateBonusSalary();
        int CalculateExperienceYears(DateTime joinDate);
    }
}
