using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pr04MaxSequenceOfEqualElements
{
    class Pr04MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] arrayInt = File.ReadAllText("input.txt").Split(' ').Select(int.Parse).ToArray();

            int count = 1;
            int maxCount = 1;
            int position = 0;

            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (i - 1 >= 0 && arrayInt[i] == arrayInt[i - 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        position = i - count + 1;
                    }
                }
                else
                {
                    count = 1;
                }
            }

            string result = "";

            for (int i = position; i < position + maxCount; i++)
            {
                result += arrayInt[i] + " ";
            }

            File.WriteAllText("output.txt", result);
        }
    }
}
