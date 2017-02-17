using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr04CharacterMultiplier
{
    class Pr04CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string firstStr = input[0];
            string secondStr = input[1];
            long sum = 0;
            if (firstStr.Length > secondStr.Length)
            {
                for (int i = 0; i < secondStr.Length; i++)
                {
                    sum += (int)firstStr[i] * (int)secondStr[i];
                }
                for (int j = secondStr.Length; j < firstStr.Length; j++)
                {
                    sum += firstStr[j];
                }
            }
            else if (secondStr.Length > firstStr.Length)
            {
                for (int i = 0; i < firstStr.Length; i++)
                {
                    sum += (int)firstStr[i] * (int)secondStr[i];
                }
                for (int j = firstStr.Length; j < secondStr.Length; j++)
                {
                    sum += secondStr[j];
                }
            }
            else if (firstStr.Length == secondStr.Length)
            {
                for (int i = 0; i < secondStr.Length; i++)
                {
                    sum += (int)firstStr[i] * (int)secondStr[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
