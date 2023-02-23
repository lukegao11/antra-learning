using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingTypes
{
    public class Exercise03
    {
        public void FizzBuzz() {

            Console.Write("Please input a number for incrementation: ");
            int num = int.Parse(Console.ReadLine());

            foreach (int i in Enumerable.Range(0, num + 1)) {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(
                        "fizz"
                    );
                }
                else Console.WriteLine(i);
            }

        }

    }
}
