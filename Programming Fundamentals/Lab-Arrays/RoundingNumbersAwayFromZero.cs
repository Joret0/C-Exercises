using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr5RoundingNumbersAwayFromZero
{
    class RoundingNumbersAwayFromZero
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            int[] arrayInt = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    arrayInt[i] = (int) Math.Floor(array[i] + 0.5);
                }
                else
                {
                    arrayInt[i] = (int)Math.Ceiling(array[i] - 0.5);
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} => {arrayInt[i]}");
            }
        }
    }
}
