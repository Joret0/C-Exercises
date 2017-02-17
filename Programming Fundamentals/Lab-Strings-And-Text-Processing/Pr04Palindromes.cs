using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr04Palindromes
{
    class Pr04Palindromes
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            List<string> result = new List<string>();

            foreach (var value in input)
            {
                if (IsPalindorome(value))
                {
                    result.Add(value);
                }
            }

            Console.WriteLine(string.Join(", ", result.OrderBy(x => x).Distinct()));
        }

        private static bool IsPalindorome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (a != b)
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}
