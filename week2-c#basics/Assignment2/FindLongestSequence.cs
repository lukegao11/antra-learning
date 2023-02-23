using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public static class FindLongestSequence
    {
        public static void FindLongest(int[] arr)
        {
            int len = arr.Length;
            int start = 0, length = 0;
            int currentStart = 0, currentLength = 0;

            for (int i = 0; i < len - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    if (currentLength == 0)
                    {
                        currentStart = i;
                    }
                    currentLength++;
                }
                else
                {
                    if (currentLength > length)
                    {
                        length = currentLength;
                        start = currentStart;
                    }
                    currentLength = 0;
                }
            }

            if (currentLength > length)
            {
                length = currentLength;
                start = currentStart;
            }

            Console.Write("Longest sequence: ");
            for (int i = start; i <= start + length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }


    }
}
