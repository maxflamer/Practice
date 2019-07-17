using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParantheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> S = new Stack<char>();
            Dictionary<char, char> Reverse = new Dictionary<char, char>();
            Reverse.Add('{', '}');
            Reverse.Add('[', ']');
            Reverse.Add('(', ')');
            string s = "[{()}]";
            char[] c = s.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (S.Count > 0 && Reverse.ContainsValue(S.Peek()))
                {
                    if (c[i] == Reverse[S.Peek()])
                        S.Pop();
                }
                
                else
                    S.Push(c[i]);
            }

            if (S.Count == 0)
                Console.WriteLine(true);

            else
                Console.WriteLine(false);
        }
    }
}
