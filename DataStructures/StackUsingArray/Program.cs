using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingArray
{
    class Program
    {
        public static int[] A = new int[10];
        public static int Top = -1;

        public static void Push(int x)
        {
            ++Top;
            if (Top > 9)
            {
                Console.WriteLine("Array limit exhausted");
                --Top;
            }

            else
                A[Top] = x;
        }

        public static void Pop()
        {
            if (Top >= 0)
                --Top;
            else
                Console.WriteLine("Array already empty");
        }

        public static void ShowTop()
        {
            if (Top >= 0)
                Console.WriteLine("Top: " + A[Top].ToString() + "\tTop index: " + Top);
            else
                Console.WriteLine("Top index: " + Top);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            for (int i = 0; i < 5; i++)
            {
                ++Top;
                A[i] = Top;
            }

            Push(9);
            Push(8);
            Push(7);
            Push(6);
            //Push(5);
            //Push(8);
            Pop();
            Pop();
            Pop();
            Pop();
            //Pop();
            //Pop();
            //Console.WriteLine(Top);
            ShowTop();
            /*for(int i=0;i<A.Length;i++)
            {
                Console.WriteLine(A[i]);
            }*/
            for (int i = 0; i <= Top; i++)
            {
                Console.WriteLine(A[i]);
            }
        }
    }
}
