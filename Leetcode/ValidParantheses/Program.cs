using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParantheses
{
    class Program
    {
        public static char InvertedParantheses(char c)
        {
            char result = '\0';
            switch (c)
            {
                case '}':
                    result = '{'; break;

                case ']':
                    result = '['; break;

                case ')':
                    result = '('; break;

                default:
                    break;
            }
            return result;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool isValid = true;
            char[] c = s.ToCharArray();
            if (c.Length == 0)
                Console.WriteLine("Length is 0");

            if (c.Length >= 1)
            {
                for (int i = 0; i < c.Length; i++)
                {
                    if (c[i] == '(' || c[i] == '[' || c[i] == '{')
                        stack.Push(c[i]);
                    else if (stack.Count > 0 && stack.Peek() == InvertedParantheses(c[i]))
                        stack.Pop();
                    else
                    {
                        isValid = false;
                        return;
                    }
                }
            }
            if (stack.Count > 0)
                isValid = false;

            Console.WriteLine(isValid);
        }
    }
}
