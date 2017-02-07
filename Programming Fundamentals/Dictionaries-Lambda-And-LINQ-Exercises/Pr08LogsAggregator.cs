using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr08LogsAggregator
{
    class Pr08LogsAggregator
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, long>> dictionary = new SortedDictionary<string, SortedDictionary<string, long>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(' ').ToArray();
                string user = info[1];
                string ip = info[0];
                long time = long.Parse(info[2]);

                if (!dictionary.ContainsKey(user))
                {
                    SortedDictionary<string, long> innerDictionary = new SortedDictionary<string, long>();
                    innerDictionary.Add(ip, time);

                    dictionary.Add(user, innerDictionary);

                }
                else
                {
                    if (!dictionary[user].ContainsKey(ip))
                    {
                        dictionary[user].Add(ip, time);
                    }
                    else
                    {
                        dictionary[user][ip] += time;
                    }
                }
            }

            foreach (var item in dictionary)
            {
                long sum = item.Value.Values.Sum();
                Console.WriteLine($"{item.Key}: {sum} [{string.Join(", ", item.Value.Keys)}]");

            }
        }
    }
}
