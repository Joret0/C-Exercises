using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pr03EqualSums
{
    class Pr03EqualSums
    {
        static void Main(string[] args)
        {
            int[] input = File.ReadAllText("input.txt").Split(' ').Select(int.Parse).ToArray();

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
                    File.WriteAllText("output.txt", i.ToString());
                    someFound = true;
                    break;
                }
            }
            if (!someFound)
            {
                File.WriteAllText("output.txt", "no");
            }
        }
    }
}
