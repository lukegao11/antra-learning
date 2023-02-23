using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW5
{
    public static class ReverseSentence
    {
        public static void Reverser()
        {
            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine();
            string separators = ".,:;=()&[]\"'\\/!? ";

            string[] words = input.Split(separators.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string[] separatorsArray = input.Split(words, StringSplitOptions.None);


            Array.Reverse(words);

            string output = "";
            for (int i = 0; i < separatorsArray.Length; i++)
            {
                output += separatorsArray[i];
                if (i < words.Length)
                {
                    output += words[i];
                }
            }
            Console.WriteLine(output);
        }
    }
}
