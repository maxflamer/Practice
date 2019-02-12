using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "XV";
            char[] c = s.ToCharArray();
            int length = c.Length;
            int[] i = new int[length];

            for (int j = 0; j < length; j++)
            {
                switch (c[j])
                {
                    case 'I':
                        i[j] = 1;
                        break;

                    case 'V':
                        i[j] = 5;
                        break;

                    case 'X':
                        i[j] = 10;
                        break;

                    case 'L':
                        i[j] = 50;
                        break;

                    case 'C':
                        i[j] = 100;
                        break;

                    case 'D':
                        i[j] = 500;
                        break;

                    case 'M':
                        i[j] = 1000;
                        break;

                    default:
                        break;
                }

            }
            for (int k = 0; k < i.Length - 1; k++)
            {
                int l = k + 1;
                if ((i[k] == 1 && i[l] == 5) || (i[k] == 1 && i[l] == 10) || (i[k] == 10 && i[l] == 50) || (i[k] == 10 && i[l] == 100) || (i[k] == 100 && i[l] == 500) || (i[k] == 100 && i[l] == 1000))
                {
                    i[k] = i[l] - i[k];

                    var numbersList = i.ToList();
                    numbersList.Remove(i[l]);
                    i = numbersList.ToArray();
                }

                else if (i[k] == i[l] && l + 1 < i.Length && i[l] == i[l + 1])
                {
                    i[k] = i[k] + i[l] + i[l + 1];

                    var numbersList = i.ToList();
                    numbersList.Remove(i[l]);
                    numbersList.Remove(i[l + 1]);
                    i = numbersList.ToArray();
                }

                else if (i[k] == i[l])
                {
                    i[k] = i[k] + i[l];

                    var numbersList = i.ToList();
                    numbersList.Remove(i[l]);
                    i = numbersList.ToArray();
                }
            }
            int finalNumber = 0;
            foreach (var item in i)
            {
                finalNumber = finalNumber + item;
            }
            Console.WriteLine(finalNumber); 
        }
    }
}
