using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr02RotateAndSum
{
    class Pr02RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] arrayInt = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            long[] sum = new long[arrayInt.Length];

            for (int i = 0; i < n; i++)
            {
                int lastElement = arrayInt[arrayInt.Length - 1];

                for (int j = arrayInt.Length - 1; j > 0; j--)
                {
                    arrayInt[j] = arrayInt[j - 1];
                }
                arrayInt[0] = lastElement;

                for (int k = 0; k < sum.Length; k++)
                {
                    sum[k] += arrayInt[k];
                }
            }

            for (int i = 0; i < arrayInt.Length; i++)
            {
                Console.Write(sum[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
