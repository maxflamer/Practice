using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationOfPostfixUsingStack
{
    class Program
    {
        public static int Evaluate(int operand2, int operand1, char operation)
        {
            int result = 0;
            switch (operation)
            {
                case '+':
                    result = operand1 + operand2;
                    break;

                case '-':
                    result = operand1 - operand2;
                    break;

                case '*':
                    result = operand1 * operand2;
                    break;

                case '/':
                    result = operand1 / operand2;
                    break;
            }
            return result;
        }

        static void Main(string[] args)
        {
            string expression = "2,3,*,5,4,*,+,9,-";
            char[] c = expression.ToCharArray();
            Stack<int> S = new Stack<int>();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == ',')
                    continue;
                if (Char.IsDigit(c[i]))
                {
                    S.Push(Int32.Parse(c[i].ToString()));
                }
                else if (c[i] == '+' || c[i] == '-' || c[i] == '*' || c[i] == '/')
                {
                    int operand2 = S.Pop();
                    int operand1 = S.Pop();
                    int result = Evaluate(operand2, operand1, c[i]);
                    S.Push(result);
                }
            }
            Console.WriteLine(S.Pop());
        }
    }
}
