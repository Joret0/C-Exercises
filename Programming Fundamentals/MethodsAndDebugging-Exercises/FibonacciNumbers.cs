using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr05FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Fibonacci(n);
        }

        private static void Fibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i <= n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            Console.WriteLine(a);
        }
    }
}
