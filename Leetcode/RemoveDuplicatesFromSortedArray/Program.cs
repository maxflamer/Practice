using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesFromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 2 };
            int length = nums.Length;
            int j = 0;
            if (length == 1)
                Console.WriteLine(nums[0]);
            else
            {


                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] != nums[i + 1])
                    {
                        nums[j] = nums[i];
                        j++;
                    }
                }
                nums[j] = nums[length - 1];
            }
            for (int i = 0; i <= j; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
