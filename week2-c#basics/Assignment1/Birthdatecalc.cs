using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingTypes
{
    public static class Birthdatecalc
    {
        public static int Birthdatecalculator(DateTime birthDay)
        {

            DateTime currentDate = DateTime.Now;
            TimeSpan timeSpan = currentDate - birthDay;
            int daysOld = (int)timeSpan.TotalDays;
            return daysOld;
        }
    }
}
