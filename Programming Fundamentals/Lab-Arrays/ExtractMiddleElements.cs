using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            int[] arrayInt = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int middle = arrayInt.Length / 2;

            if (arrayInt.Length == 1)
            {
                Console.WriteLine(arrayInt[0]);
            }
            else if (arrayInt.Length % 2 == 0)
            {
                Console.WriteLine($"{arrayInt[middle - 1]}, {arrayInt[middle]}");
            }
            else
            {
                Console.WriteLine($"{arrayInt[middle - 1]}, {arrayInt[middle]}, {arrayInt[middle + 1]}");
            }
        }
    }
}
