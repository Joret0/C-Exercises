using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr03DressPattern
{
    class Pr03DressPattern
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Magic("_", n * 4) + "." + Magic("_", n * 4) + "." + Magic("_", n * 4));
            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine(Magic("_", n * 4 - 2 - 2 * i) + "." + Magic("*", 2 + 3 * i) + "." + Magic("_", n * 4 - 2 - 2 * i) + "." + Magic("*", 2 + 3 * i) + "." + Magic("_", n * 4 - 2 - 2 * i));
                
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("." + Magic("*", n * 12) + ".");
            }
            Console.WriteLine(Magic(".", n * 3) + Magic("*", n * 6 + 2) + Magic(".", n * 3));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Magic("_", n * 3) + Magic("o", n * 6 + 2) + Magic("_", n * 3));
            }
            for (int i = 0; i < n * 3; i++)
            {
                Console.WriteLine(Magic("_", 3 * n - i) + "." + Magic("*", 6 * n + i * 2) + "." + Magic("_", 3 * n - i));
            }
            Console.WriteLine(Magic(".", 12 * n + 2));
        }
        private static string Magic(string s, int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(s);
            }
            return sb.ToString();
        }
    }
}
