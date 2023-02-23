using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingTypes
{
    public class NumCounter
    {
        public void NumberCounter() {

            for (int i = 1; i < 5; i++) {

                Console.WriteLine("\n");   
                for (int j = 0; j < 25; j += i) {

                    Console.Write(j);
                    Console.Write(", ");

                }
            
            
            
            }
        
        
        
        
        }
    }
}
