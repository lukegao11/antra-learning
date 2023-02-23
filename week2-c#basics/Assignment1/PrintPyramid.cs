using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingTypes
{
    public static class PrintPyramid
    {
        public static void Pyramidprinter(int num) {
            for (int i = 0; i < num; i++) {
                Console.WriteLine("\n");
                for (int j = 0; j < num - i - 1; j++) {
                    Console.Write(" ");
                }
                for (int l = 0; l < 2 * i + 1; l++) { 
                
                    Console.Write("*");
                }

                for (int k = 0; k < num - i - 1; k++)
                {
                    Console.Write(" ");
                }
            }
        
        }

    }
}
