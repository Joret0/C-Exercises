using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Pr02ConvertFromBaseNToBase10
{
    class Pr02ConvertFromBaseNToBase10
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            BigInteger number = BigInteger.Parse(input[1]);
            int baseNum = int.Parse(input[0]);

            var numberReverse = number.ToString().Reverse().ToArray();
            string numberToConvert = new string(numberReverse);
            var sum = new BigInteger(0);

            for (int pow = 0; pow < numberToConvert.Length; pow++)
            {
                var num = int.Parse(numberToConvert[pow].ToString());

                sum += num * BigInteger.Pow(baseNum, pow);
            }

            Console.WriteLine(sum);
        }
    }
}
