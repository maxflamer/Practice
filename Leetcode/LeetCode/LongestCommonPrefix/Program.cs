using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "flower", "flow", "flight" };
            int indexOfShortestWord = 0, ShortestValue = 0, numberOfSameLetters = 0;
            string finalString = string.Empty;
            List<int> numberOfSameLettersList = new List<int>();

            List<char> c = new List<char>();
            for (int i = 0; i < strs.Length - 1; i++)
            {
                char[] c1 = new char[strs[i].Length];
                c1 = strs[i].ToCharArray();

                char[] c2 = new char[strs[i + 1].Length];
                c2 = strs[i + 1].ToCharArray();

                for (int j = 0; j < c1.Length && j < c2.Length; j++)
                {
                    if (c1[j] == c2[j])
                    {
                        ++numberOfSameLetters;
                    }
                    else
                        break;
                }
                numberOfSameLettersList.Add(numberOfSameLetters);
                numberOfSameLetters = 0;
            }
            if (strs.Length == 1)
                Console.WriteLine(strs[0]);

            else if (strs.Length < 1 || strs == null || numberOfSameLettersList == null)
            {
                Console.WriteLine("");
            }
            else
            {
                ShortestValue = numberOfSameLettersList.Min();
                indexOfShortestWord = numberOfSameLettersList.IndexOf(ShortestValue);
                finalString = strs[indexOfShortestWord].Substring(0, ShortestValue);
                Console.WriteLine(finalString);
            }
        }
    }
}
