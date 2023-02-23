using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public static class FindFrequentNum
    {
        public static int FindMostFrequentNumber(int[] numbers)
        {
            Dictionary<int, int> frequencies = new Dictionary<int, int>();
            int maxFrequency = 0;
            int mostFrequentNumber = numbers[0];

            foreach (int number in numbers)
            {
                if (frequencies.ContainsKey(number))
                {
                    frequencies[number]++;
                }
                else
                {
                    frequencies[number] = 1;
                }

                if (frequencies[number] > maxFrequency ||
                    (frequencies[number] == maxFrequency && number < mostFrequentNumber))
                {
                    maxFrequency = frequencies[number];
                    mostFrequentNumber = number;
                }
            }

            return mostFrequentNumber;
        }


    }
}
