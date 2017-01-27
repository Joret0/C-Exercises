using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace pr14FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            CountTrailingZeroes(n);
        }

        private static void CountTrailingZeroes(int n)
        {
            
            int countZeroes = 0;

            for (int i = 5; n / i >= 1; i *= 5)
            {
                countZeroes += n / i;
            }

            Console.WriteLine(countZeroes);
        }
    }
}
