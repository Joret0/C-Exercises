using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr02MaxMethod
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            GetMax(first, second, third);
        }

        private static void GetMax(int first, int second, int third)
        {
            if (first > second && first > third)
            {
                Console.WriteLine(first);
            }
            else if (second > third)
            {
                Console.WriteLine(second);
            }
            else
            {
                Console.WriteLine(third);
            }
        }
    }
}
