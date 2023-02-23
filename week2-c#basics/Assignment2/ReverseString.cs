using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public class ReverseString
    {
        public static void ReverseStringUsingChar()
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            Console.WriteLine("Reversed string: " + reversedString);
        }

        public static void ReverseStringUsingLoop()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            char[] reversedChars = new char[input.Length];

            for (int i = input.Length - 1, j = 0; i >= 0; i--, j++)
            {
                reversedChars[j] = input[i];
            }

            string reversedString = new string(reversedChars);
            Console.WriteLine("Reversed string: " + reversedString);
        }
        

    }
}
