using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Week2Assignment3
{
    public class Person : IPersonService
    {
        public DateTime BirthDate { get; set; }
        public List<string> Addresses { get; set; }

        public Person(DateTime birthDate, List<string> addresses)
        {
            BirthDate = birthDate;
            Addresses = addresses;
        }


        public int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age))
                age--;
            return age;
        }

        public virtual decimal CalculateSalary(decimal baseSalary)
        {
            if (baseSalary < 0)
                throw new ArgumentOutOfRangeException("Base salary cannot be negative.");
            return baseSalary;
        }

        public List<string> GetAddresses()
        {
            return Addresses;
        }
    }

}
