using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr06UserLogs
{
    class Pr06UserLogs
    {
        static void Main(string[] args)
        {
            string input = "";
            SortedDictionary<string, Dictionary<string, int>> dictionary = new SortedDictionary<string, Dictionary<string, int>>();
            int count = 0;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] array = input.Split(' ');
                string ip = new string(array[0].Skip(3).ToArray());
                string user = new string(array[2].Skip(5).ToArray());

                if (!dictionary.ContainsKey(user))
                {
                    count++;
                    var innerDictionary = new Dictionary<string, int>();
                    innerDictionary.Add(ip, count);
                    dictionary.Add(user, innerDictionary);
                    count = 0;
                }
                else
                {
                    if (!dictionary[user].ContainsKey(ip))
                    {
                        count++;
                        dictionary[user].Add(ip, count);
                        count = 0;
                    }
                    else
                    {
                        count++;
                        dictionary[user][ip] += count;
                        count = 0;
                    }
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine("{0}:", item.Key);
                foreach (var ips in dictionary[item.Key])
                {
                    if (ips.Key == item.Value.Keys.Last())
                    {
                        Console.WriteLine($"{ips.Key} => {ips.Value}.");
                    }
                    else
                    {
                        Console.Write($"{ips.Key} => {ips.Value}, ");
                    }
                }
            }
        }
    }
}
