using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr13Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            AcountFactorial(n);
                
        }

        private static void AcountFactorial(int n)
        {
            BigInteger number = 1;

            for (int i = 1; i <= n; i++)
            {
                number *= i;
            }

            Console.WriteLine(number);
        }
    }
}
