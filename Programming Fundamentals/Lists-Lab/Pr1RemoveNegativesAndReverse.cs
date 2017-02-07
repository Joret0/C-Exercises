using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1RemoveNegativesAndReverse
{
    class Pr1RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            integers.Reverse();
            integers.RemoveAll(x => x < 0);

            if (integers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                integers.ForEach(x => Console.Write(x + " "));
                Console.WriteLine();
            }
        }
    }
}
