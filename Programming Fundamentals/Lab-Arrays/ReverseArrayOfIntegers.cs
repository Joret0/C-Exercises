using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2ReverseArrayOfIntegers
{
    class ReverseArrayOfIntegers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arrayInt = new int[n];

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                arrayInt[i] = num;
            }

            for (int i = arrayInt.Length - 1; i >= 0; i--)
            {
                Console.Write(arrayInt[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
