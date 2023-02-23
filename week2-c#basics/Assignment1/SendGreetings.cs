using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingTypes
{
    public class SendGreetings
    {
        public void GreetingsSender() {

            DateTime currentTime = DateTime.Now;
            int hour = currentTime.Hour;

            if (hour >= 5 && hour < 12)
            {
                Console.WriteLine("Good Morning!");
            }
            if (hour >= 12 && hour < 17)
            {
                Console.WriteLine("Good Afternoon!");
            }
            if (hour >= 17 && hour < 20)
            {
                Console.WriteLine("Good Evening!");
            }
            if (hour >= 20 || hour < 5)
            {
                Console.WriteLine("Good Night!");
            }

        }
    }
}
