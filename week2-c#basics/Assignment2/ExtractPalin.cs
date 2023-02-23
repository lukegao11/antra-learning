using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public static class ExtractPalin
    {

        //to check if a string is a palindrome
        public static bool IsPalindrome(string s)
        {
            // Convert the string to a character array and define two pointers to the start and end of the array
            char[] charArray = s.ToCharArray();
            int start = 0;
            int end = charArray.Length - 1;

            // Loop over the array until the pointers meet in the middle
            while (start < end)
            {
                // If the characters at the start and end pointers are not the same, the string is not a palindrome
                if (charArray[start] != charArray[end])
                {
                    return false;
                }

                // Move the pointers towards the middle
                start++;
                end--;
            }

            // If we reach this point, the string is a palindrome
            return true;
        }
        public static void PalindromeExtracter(string sent)
        {
            // Define the list of separators and convert the text to lowercase
            char[] separators = new char[] { ' ', '.', ',', ':', ';', '!', '?', '-', '_', '@', '#', '$', '%', '^', '&', '*', '(', ')', '[', ']', '{', '}', '/', '\\', '|', '<', '>' };
            sent = sent.ToLower();

            // Define a HashSet to store the unique palindromes
            HashSet<string> palindromes = new HashSet<string>();

            // Split the text into an array of words using the separators
            string[] wordArray = sent.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // Loop over each word in the array and check if it's a palindrome
            foreach (string word in wordArray)
            {
                // Check if the word is a palindrome
                if (IsPalindrome(word))
                {
                    // Add the palindrome to the HashSet
                    palindromes.Add(word);
                }
            }

            // Sort the palindromes and print them on a single line, separated by comma and space
            Console.WriteLine(string.Join(", ", palindromes.OrderBy(p => p)));
        }




    }
}
