using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr07CountNumbers
{
    class Pr07CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            input.Sort();

            int first = input[0];
            int count = 1;

            for (int i = 1; i < input.Count; i++)
            {
                int current = input[i];
                if (current == first)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{first} -> {count}");
                    count = 1;
                }

                first = current;
            }
            Console.WriteLine($"{first} -> {count}");
        }
    }
}
