using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr08LettersChangeNumbers
{
    class Pr08LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;

            for (int i = 0; i < line.Length; i++)
            {
                string input = line[i].Trim();
                string firstLetter = input.Substring(0, 1);
                string endLetter = input.Substring(input.Length - 1);
                double number = Double.Parse(input.Substring(1, input.Length - 1 - 1));
                int firstLetterPos = firstLetter[0] >= 'A' && firstLetter[0] <= 'Z' ?
                    firstLetter[0] - 64 : firstLetter[0] - 96;
                int secondLetterPos = endLetter[0] >= 'A' && endLetter[0] <= 'Z' ?
                    endLetter[0] - 64 : endLetter[0] - 96;
                if (!char.IsLower(firstLetter[0]))
                {
                    number /= firstLetterPos;
                }
                else
                {
                    number *= firstLetterPos;
                }
                if (!char.IsLower(endLetter[0]))
                {
                    number -= secondLetterPos;
                }
                else
                {
                    number += secondLetterPos;
                }
                sum += number;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
