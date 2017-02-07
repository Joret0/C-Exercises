using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr02OddOccurrences
{
    class Pr02OddOccurrences
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split(' ');

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (var item in input)
            {
                if (!dictionary.ContainsKey(item))
                {
                    dictionary.Add(item, 0);
                }

                dictionary[item]++;
            }

            List<string> list = new List<string>();

            foreach (var item in dictionary)
            {
                if (item.Value % 2 != 0)
                {
                    list.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
