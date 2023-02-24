using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Week2Assignment3
{
    public interface IPersonService
    {
        int CalculateAge(DateTime birthDate);
        decimal CalculateSalary(decimal baseSalary);
        List<Address> GetAddresses();
    }
}
