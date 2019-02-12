using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 12, 3, 5 };
            int target = 9;
            int i, j;
            int[] answer = new int[2];
            for (i = 0; i < nums.Length; i++)
            {
                for (j = 1; j < nums.Length && j != i; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        answer[0] = i;
                        answer[1] = j;
                    }
                }
            }
            Console.WriteLine(answer);
        }
    }
}
