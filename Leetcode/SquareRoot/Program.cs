using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            int x = 2147483647;
            if (x == 0)
                Console.WriteLine("0");
            double j = 1;
            int matched = 0;
            while (j * j <= x)
            {
                if (j * j == x)
                {
                    matched = 1;
                    break;
                }
                j++;
            }
            if (matched != 1)
                j--;
            int i = Convert.ToInt32(j);
            Console.WriteLine(i);
        }
    }
}
