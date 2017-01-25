using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr04DrawFilledSquare
{
    class DrawFilledSquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintShape(n);
        }

        private static void PrintShape(int n)
        {
            PrintHeader(n);
            PrintBody(n);
            PrintFooter(n);
        }

        private static void PrintFooter(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        private static void PrintBody(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write('-');
                for (int j = 1; j < n; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }

        private static void PrintHeader(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
