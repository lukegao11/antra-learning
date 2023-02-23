using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public class RotateSumArray
    {
        public void RotateSum() {

            // read input array
            Console.Write("Enter an integer array, seperat by space: ");
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            // read k
            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());

            // calculate sums
            int n = nums.Length;
            int[] sums = new int[n];
            for (int r = 1; r <= k; r++)
            {
                for (int i = 0; i < n; i++)
                {
                    sums[(i + r) % n] += nums[i];
                }
            }

            // print sums
           Console.WriteLine(string.Join(" ", sums));


        }

    }
}
