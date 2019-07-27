using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            int[] digits = new int[] { 4, 3, 2, 1 };

            if (digits.Length == 0)
            {
                int[] plusOne = new int[1];
                plusOne[0] = 1;
                Console.WriteLine(plusOne[0]);
                return;
            }

            if (digits[digits.Length - 1] != 9)
                digits[digits.Length - 1]++;
            else
            {
                digits[digits.Length - 1] = 0;
                int carry = 1;
                for (int i = digits.Length - 2; i >= 0; i--)
                {
                    if (carry == 1)
                    {
                        if (digits[i] == 9)
                        {
                            digits[i] = 0;
                            carry = 1;
                        }
                        else
                        {
                            digits[i]++;
                            carry = 0;
                            break;
                        }
                    }
                    else
                    {
                        digits[i]++;
                        carry = 0;
                        break;
                    }
                }
                if (carry == 1)
                {
                    int[] plusOne = new int[digits.Length + 1];
                    plusOne[0] = 1;
                    for (int i = 0; i < digits.Length; i++)
                    {
                        plusOne[i + 1] = digits[i];
                    }
                    for (int i = 0; i < plusOne.Length; i++)
                    {
                        Console.WriteLine(plusOne[i]);
                    }
                }

            }
            for (int i = 0; i < digits.Length; i++)
            {
                Console.WriteLine(digits[i]);
            }
        }
    }
}
