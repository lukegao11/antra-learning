using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Assignment3
{
    public static class ReverseArray
    {

        public static int[] GenerateNumbers(int length)
        {
            Random random = new Random();
            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                numbers[i] = random.Next(1, 101); // generates a random integer between 1 and 100
            }

            return numbers;
        }

        public static void Reverse(int[] numbers)
        {
            int left = 0;
            int right = numbers.Length - 1;
            while (left < right)
            {
                int temp = numbers[left];
                numbers[left] = numbers[right];
                numbers[right] = temp;
                left++;
                right--;
            }
        }

        public static void PrintNumbers(int[] numbers)
        {
            Console.WriteLine(string.Join(", ", numbers));
        }

    }
}
