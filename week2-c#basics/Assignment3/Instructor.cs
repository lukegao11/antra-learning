using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Assignment3
{
    public class Instructor : Person, IInstructorService
    {
        public Department Department { get; set; }
        public bool IsDepartmentHead { get; set; }
        public DateTime JoinDate { get; set; }
        public decimal BonusSalaryPerYear { get; set; }

        public Instructor(Department department, bool isDepartmentHead, DateTime joinDate, decimal bonusSalaryPerYear, DateTime birthDate, List<string> addresses) : base(birthDate, addresses)
        {
            Department = department;
            IsDepartmentHead = isDepartmentHead;
            JoinDate = joinDate;
            BonusSalaryPerYear = bonusSalaryPerYear;
        }

        public decimal CalculateBonusSalary()
        {
            int years = CalculateExperienceYears(JoinDate);
            return years * BonusSalaryPerYear;
        }

        public int CalculateExperienceYears(DateTime joinDate)
        {
            DateTime today = DateTime.Today;
            int years = today.Year - joinDate.Year;
            if (joinDate > today.AddYears(-years))
                years--;
            return years;
        }
    }
}
