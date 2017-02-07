using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr01MaxSequenceOfEqualElements
{
    class Pr01MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int count = 1;
            int maxCount = 1;
            int position = 0;
            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == input[i - 1])
                {
                    count++;
                    if (maxCount < count)
                    {
                        maxCount = count;
                        position = i - count + 1;
                    }
                }
                else
                {
                    count = 1;
                }
            }

            for (int i = position; i < position + maxCount; i++)
            {
                Console.Write(input[i] + " ");
            }
        }
    }
}
