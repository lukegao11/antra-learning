using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Assignment3
{
    public static class Fibonacci
    {
        public static int nthFibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            int a = 0, b = 1;
            for (int i = 2; i <= n; i++)
            {
                int c = a + b;
                a = b;
                b = c;
            }

            return b;
        }


    }
}
