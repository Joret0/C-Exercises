using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr8CondenseArrayNumber
{
    class CondenseArrayNumber
    {
        static void Main(string[] args)
        {
            int[] arrayInt = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] convertedArray = new int[arrayInt.Length - 1];

            if (arrayInt.Length == 1)
            {
                Console.WriteLine(arrayInt[0]);
            }
            else
            {
                for (int i = 0; i < arrayInt.Length; i++)
                {
                    for (int j = 0; j < convertedArray.Length - i; j++)
                    {
                        convertedArray[j] = arrayInt[j] + arrayInt[j + 1];
                    }
                    arrayInt = convertedArray;
                }
                Console.WriteLine(convertedArray[0]);
            }
        }
    }
}
