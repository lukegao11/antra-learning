using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public class ManageItem
    {
        public void Run() {
            List<string> my_list = new List<string>();

            // Infinite loop until user exits
            while (true)
            {
                // Ask the user for input
                Console.Write("Enter an operation (+item, -item, or --): ");
                string input = Console.ReadLine();

                // Determine the operation to perform
                if (input.StartsWith("+"))
                {
                    // Add the item to the list
                    string item = input.Substring(1);
                    my_list.Add(item);
                }
                else if (input.StartsWith("-"))
                {
                    // Remove the item from the list
                    string item = input.Substring(1);
                    my_list.Remove(item);
                }
                else if (input == "--")
                {
                    Console.WriteLine("Clearing");
                    // Clear the list
                    my_list.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                // Display the current contents of the list
                Console.WriteLine("Current list:");
                foreach (string item in my_list)
                {
                    Console.WriteLine("- " + item);
                }
                Console.WriteLine();
            }





        }



    }
}
