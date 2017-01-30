using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr07MaxSequenceOfIncreasingElements
{
    class Pr07MaxSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            int[] arrayInt = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 0;
            int maxCount = 0;
            int position = 0;

            for (int i = 1; i < arrayInt.Length; i++)
            {
                if (arrayInt[i] - arrayInt[i - 1] >= 1)
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        position = i - count;
                    }
                }
                else
                {
                    count = 0;
                }
            }

            for (int i = position; i <= position + maxCount; i++)
            {
                Console.Write(arrayInt[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
