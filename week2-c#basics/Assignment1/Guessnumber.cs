using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingTypes
{
    public class Guessnumber
{
        public int generatenumber() { 
            Random random= new Random();
            int r = random.Next(1, 4);
            return r;
        }


        public void guessnumber(int a, int b) { 


            if (a < 1 || a > 3 )
            {
                Console.WriteLine("The number you input is outside of the range " +
                    "of numbers that are valid guesses.\nPlease try again");
            }
            else
            {
                if (a < b) {
                    Console.WriteLine("The number you input is lower than the target");
                }else if (a > b)
                {
                    Console.WriteLine("The number you input is higher than the target");
                } else
                {
                    Console.WriteLine("Congratulations! you are right! the number is indeed {0}!", a);
                }
                
            } 
                
        
        }



}
}
