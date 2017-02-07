using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4SumReversedNumbers
{
    class Pr4SumReversedNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string tempString = new string(input[i].Reverse().ToArray());
                sum += int.Parse(tempString);
            }
            Console.WriteLine(sum);
        }
    }
}
