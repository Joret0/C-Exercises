using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr01CountRealNumbers
{
    class Pr01CountRealNumbers
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            SortedDictionary<double, int> dictionary = new SortedDictionary<double, int>();

            foreach (var item in list)
                }

            {
                if (!dictionary.ContainsKey(item))
                {
                    dictionary.Add(item, 0);
                dictionary[item]++;
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}