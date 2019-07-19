using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringUsingStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Stack<char> S = new Stack<char>();
            string s = "Random String";
            for (int i = 0; i < s.Length; i++)
            {
                S.Push(s[i]);
            }
            char[] c = s.ToCharArray();
            Console.WriteLine("Reversed String:");
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = S.Pop();
                Console.Write(c[i]);
            }
            Console.WriteLine();
        }
    }
}
