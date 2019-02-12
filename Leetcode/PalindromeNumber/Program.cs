using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 121;
            int reverse = 0, lastDigit = 0; bool pallindrome = true;
            List<int> digits = new List<int>();

            if (x < 0 || (x > 0 && (x % 10 == 0)))
            {
                Console.WriteLine(false);
            }
            else
            {
                while (x != 0)
                {
                    lastDigit = x % 10;
                    digits.Add(lastDigit);
                    x /= 10;

                    reverse = reverse * 10 + lastDigit;
                }

                int length = digits.Count;

                for (int i = 0; i < length / 2; i++)
                {
                    if (digits[i] != digits[length - 1 - i])
                    {
                        pallindrome = false;
                    }
                }
                Console.WriteLine(pallindrome);
            }
        }
    }
}
