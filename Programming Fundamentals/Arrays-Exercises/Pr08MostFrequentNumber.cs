using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr08MostFrequentNumber
{
    class Pr08MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] arrayInt = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
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
            Console.WriteLine(maxFrequent);
        }
    }
}
