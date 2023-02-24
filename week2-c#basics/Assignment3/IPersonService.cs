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
        int CalculateAge();
        decimal CalculateSalary(decimal baseSalary);
        List<string> GetAddresses();
    }
}
