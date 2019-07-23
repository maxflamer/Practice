using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInsertPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 3, 5, 6 };
            int target = 7;

            if (nums[0] > target)
                Console.WriteLine("0");
            else if (nums[nums.Length - 1] == target)
                Console.WriteLine(nums.Length - 1);
            else if (nums[nums.Length - 1] < target)
                Console.WriteLine(nums.Length);
            else
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] == target)
                        Console.WriteLine(i);
                    else if (nums[i] < target && nums[i + 1] > target)
                        Console.WriteLine(i + 1);
                }
            }
        }
    }
}
