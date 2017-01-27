using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr7SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] newArray = new int[Math.Max(array1.Length, array2.Length)];

            for (int i = 0; i < newArray.Length; i++)
            {
                int sum = array1[i % array1.Length] + array2[i % array2.Length];
                if (i >= newArray.Length)
                {
                    break;
                }
                Console.Write(sum + " ");
            }
            Console.WriteLine();
        }
    }
}
