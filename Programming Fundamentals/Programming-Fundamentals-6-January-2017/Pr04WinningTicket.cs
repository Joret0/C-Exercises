using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pr04WinningTicket
{
    class Pr04WinningTicket
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();
            Regex regex = new Regex(@"([$]{6,10}|[\^]{6,10}|[@]{6,10}|[#]{6,10})");
            List<string> output = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length != 20)
                {
                    output.Add("invalid ticket");
                    continue;
                }
                string leftSide = input[i].Substring(0, input[i].Length / 2);
                string rightSide = input[i].Substring(input[i].Length / 2);
                Match leftPart = regex.Match(leftSide);
                Match rightPart = regex.Match(rightSide);

                string result = "";

                if (leftPart.Success && rightPart.Success)
                {
                    int leftLenght = leftPart.Groups[0].Value.Length;
                    int rightLenght = rightPart.Groups[0].Value.Length;

                    char symbolLeft = leftPart.Groups[0].Value.Distinct().ToArray().First();
                    char symbolRight = rightPart.Groups[0].Value.Distinct().ToArray().First();

                    if (!symbolLeft.Equals(symbolRight))
                    {
                        result = $"ticket \"{input[i]}\" - no match";
                    }
                    else if (leftLenght == 10 && rightLenght == 10)
                    {
                        result = $"ticket \"{input[i]}\" - {leftLenght}{symbolLeft} Jackpot!";
                    }
                    else if (leftLenght >= 6 && rightLenght >= 6)
                    {
                        int lenght = leftLenght > rightLenght ? rightLenght : leftLenght;
                        result = $"ticket \"{input[i]}\" - {lenght}{symbolLeft}";
                    }
                }
                else
                {
                    result = $"ticket \"{input[i]}\" - no match";
                }

                output.Add(result);
            }

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
