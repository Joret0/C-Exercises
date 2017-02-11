using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr02RandomizeWords
{
    class Pr02RandomizeWords
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Random random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int number = random.Next(input.Length);

                string tempWord = input[i];
                input[i] = input[number];
                input[number] = tempWord;
            }
            Console.WriteLine(string.Join("\r\n", input));

        }
    }
}
