using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr09IndexOfLetters
{
    class Pr09IndexOfLetters
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{input[i]} -> {input[i] - 'a'}");
            }
        }
    }
}
