using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumSumOfSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            if (nums.Length == 0)
                Console.WriteLine("Return zero");
            if (nums.Length == 1)
                Console.WriteLine(nums[0]);
            int sum = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = nums[i];
                if (temp > sum)
                    sum = temp;
                for (int j = i; j < nums.Length; j++)
                {
                    if (i == j)
                        continue;

                    temp += nums[j];
                    if (temp > sum)
                        sum = temp;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
