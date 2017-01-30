using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr11EqualSums
{
    class Pr11EqualSums
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool someFound = false;

            for (int i = 0; i < input.Length; i++)
            {
                long leftSum = 0;
                long rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += input[j];
                }

                for (int j = i + 1; j < input.Length; j++)
                {
                    rightSum += input[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    someFound = true;
                    break;
                }
            }
            if (!someFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
