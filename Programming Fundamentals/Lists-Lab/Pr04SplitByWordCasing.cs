using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr04SplitByWordCasing
{
    class Pr04SplitByWordCasing
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':','.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' },
                StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> wordsWithLowerCases = new List<string>();
            List<string> wordsWithUperCases = new List<string>();
            List<string> wordsWithMixedCases = new List<string>();

            foreach (var item in input)
            {
                bool isLowerCase = true;
                bool isUperCase = true;

                for (int i = 0; i < item.Length; i++)
                {
                    if (char.IsLower(item[i]))
                    {
                        isUperCase = false;
                    }
                    else if (char.IsUpper(item[i]))
                    {
                        isLowerCase = false;
                    }
                    else
                    {
                        isUperCase = false;
                        isLowerCase = false;
                    }
                }

                if (isLowerCase)
                {
                    wordsWithLowerCases.Add(item);
                }
                else if (isUperCase)
                {
                    wordsWithUperCases.Add(item);
                }
                else
                {
                    wordsWithMixedCases.Add(item);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(",", wordsWithLowerCases));
            Console.WriteLine("Mixed-case: {0}", string.Join(",", wordsWithMixedCases));
            Console.WriteLine("Upper-case: {0}", string.Join(",", wordsWithUperCases));
        }
    }
}
