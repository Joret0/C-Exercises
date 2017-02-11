using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pr01MostFrequentNumber
{
    class Pr01MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] arrayInt = File.ReadAllText("input.txt").Split(' ').Select(int.Parse).ToArray();
            int maxFrequent = 0;
            int maxCount = 0;

            for (int i = 0; i < arrayInt.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < arrayInt.Length; j++)
                {
                    if (arrayInt[i] == arrayInt[j])
                    {
                        counter++;
                        if (maxCount < counter)
                        {
                            maxCount = counter;
                            maxFrequent = arrayInt[i];
                        }
                    }
                }
            }
            File.WriteAllText("output.txt", maxFrequent.ToString());
        }
    }
}
