using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr03UnicodeCharacters
{
    class Pr03UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"\\u{(int)input[i]:x4}");
            }
            Console.WriteLine();
        }
    }
}
