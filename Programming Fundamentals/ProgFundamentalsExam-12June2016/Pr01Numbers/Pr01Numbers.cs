using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr01Numbers
{
    class Pr01Numbers
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> list = new List<int>();
            double average = input.Average();
            int count = 0;
            bool hasFound = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > average)
                {
                    list.Add(input[i]);
                    count++;
                    hasFound = true;
                }
            }
            if (hasFound)
            {
                Console.WriteLine(string.Join(" ", list.OrderByDescending(x => x).Take(5)));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
