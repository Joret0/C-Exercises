using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr06SquareNumbers
{
    class Pr06SquareNumbers
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(a => a).ToList();

            foreach (var item in input)
            {
                var help = Math.Sqrt(item);

                if (help == (int)help)
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
