using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr01LargestCommonEnd
{
    class Pr01LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            int rightToLeftCounter = 0;
            int leftToRightCounter = 0;

            for (int i = 0; i < firstArray.Length && i < secondArray.Length ; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    leftToRightCounter++;
                }
            }

            for (int i = 0; i < firstArray.Length && i < secondArray.Length; i++)
            {
                if (firstArray[firstArray.Length - i - 1] == secondArray[secondArray.Length - i - 1])
                {
                    rightToLeftCounter++;
                }
            }

            if (leftToRightCounter > rightToLeftCounter)
            {
                Console.WriteLine(leftToRightCounter);
            }
            else
            {
                Console.WriteLine(rightToLeftCounter);
            }
        }
    }
}
