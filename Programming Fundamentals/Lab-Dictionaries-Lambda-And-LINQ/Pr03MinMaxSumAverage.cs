using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr03MinMaxSumAverage
{
    class Pr03MinMaxSumAverage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> integers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                integers.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Sum = {0}", integers.Sum());
            Console.WriteLine("Min = {0}", integers.Min());
            Console.WriteLine("Max = {0}", integers.Max());
            Console.WriteLine("Average = {0}", integers.Average());
        }
    }
}
