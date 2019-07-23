using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 2, 2, 3 };
            int val = 3;
            int j = 0;

            if (nums.Length == 0)
                Console.WriteLine("0");

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[j] = nums[i];
                    j++;
                }
            }
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.WriteLine("Array Length: " + j);
        }
    }
}
