using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrSoftUniKaraoke
{
    class PrSoftUniKaraoke
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToArray();
            string[] songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).ToArray();

            Dictionary<string, SortedDictionary<string, int>> dictinary = new Dictionary<string, SortedDictionary<string, int>>();

            
            string input = "";
            while ((input = Console.ReadLine()) != "dawn")
            {
                string[] info = input.Split(new string[] { ", " }, StringSplitOptions.None).ToArray();
                string key = info[0];
                string song = info[1];
                string reward = info[2];

                if (participants.Contains(key) && songs.Contains(song))
                {
                    if (!dictinary.ContainsKey(key))
                    {
                        SortedDictionary<string, int> nested = new SortedDictionary<string, int>();
                        nested.Add(reward, 1);
                        dictinary.Add(key, nested);
                    }
                    else
                    {
                        if (!dictinary[key].ContainsKey(reward))
                        {
                            dictinary[key].Add(reward, 1);
                        }
                        else
                        {
                            dictinary[key][reward]++;
                        }
                    }
                }
            }
            if (dictinary.Values.Count() == 0)
            {
                Console.WriteLine("No awards");
            }
            
            foreach (var item in dictinary.OrderByDescending(x => x.Value.Values.Count()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Values.Count()} awards");
                foreach (var award in dictinary[item.Key])
                {
                    Console.WriteLine($"--{award.Key}");
                }
            }
        }
    }
}
