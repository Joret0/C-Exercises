using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr06FoldAndSum
{
    class Pr06FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = input.Length / 4;
            int[] rowLeft = input.Take(k).Reverse().ToArray();
            int[] rowRight = input.Reverse().Take(k).ToArray();
            int[] array1 = rowLeft.Concat(rowRight).ToArray();
            int[] array2 = input.Skip(k).Take(2 * k).ToArray();

            var result = array1.Select((x, index) => x + array2[index]);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
