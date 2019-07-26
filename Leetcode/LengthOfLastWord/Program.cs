using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthOfLastWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello to you   ";
            char[] c = s.ToCharArray();
            int length = 0;
            if (c.Length == 0)
                Console.WriteLine("Zero");

            else
            {

                for (int i = 1; i <= c.Length - 1; i++)
                {
                    if (c[i - 1] != ' ')
                    {
                        length++;
                    }
                    else if (c[i - 1] == ' ' && c[i] != ' ')
                    {
                        length = 0;
                    }
                }

            }
            if (c[c.Length - 1] != ' ')
            {
                length++;
            }

            Console.WriteLine(length);
        }
    }
}
