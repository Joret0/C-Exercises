using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pr04MergeFiles
{
    class Pr04MergeFiles
    {
        static void Main(string[] args)
        {
            string[] textOne = File.ReadAllLines("FileOne.txt");
            string[] textTwo = File.ReadAllLines("FileTwo.txt");
            
            string[] result = new string[textOne.Length + textTwo.Length];
            int index = 0;

            for (int i = 0; i < textOne.Length * 2; i++)
            {
                if (i % 2 == 0)
                {
                    result[i] = textOne[index];
                }
                else
                {
                    result[i] = textTwo[index];
                    index++;
                }
            }

            File.WriteAllLines("output.txt", result);
        }
    }
}
