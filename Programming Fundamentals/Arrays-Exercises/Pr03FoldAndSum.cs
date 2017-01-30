using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr03FoldAndSum
{
    class Pr03FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = inputArray.Length / 4;
            int[] firtsRow = new int[k * 2];
            int[] secondRow = new int[k * 2];

            
            for (int i = k - 1; i >= 0; i--)
            {
                firtsRow[i] = inputArray[k - i - 1];
            }
            
            for (int j = k - 1; j >= 0; j--)
            {
                firtsRow[k + j] = inputArray[inputArray.Length - 1 - j];
            }

            for (int i = 0; i < k * 2; i++)
            {
                secondRow[i] = inputArray[k + i];
            }
            
            for (int i = 0; i < 2 * k; i++)
            {
                Console.Write(firtsRow[i] + secondRow[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
