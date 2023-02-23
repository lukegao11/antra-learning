using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public class GetPrimeNum
    {
        public static int[] FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primeNums = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    primeNums.Add(i);
                }
            }

            return primeNums.ToArray();
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }



    }
}
