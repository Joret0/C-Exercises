using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Pr01ConvertFromBase10ToBaseN
{
    class Pr01ConvertFromBase10ToBaseN
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            BigInteger number = BigInteger.Parse(input[1]);
            int baseNum = int.Parse(input[0]);
            string result = string.Empty;
            while(number > 0)
            {
                var remainder = number % baseNum;
                result = remainder + result;
                number /= baseNum;
            }
            Console.WriteLine(result);
        }
    }
}
