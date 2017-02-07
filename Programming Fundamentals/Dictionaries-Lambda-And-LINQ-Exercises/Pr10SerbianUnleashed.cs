using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pr10SerbianUnleashed
{
    class Pr10SerbianUnleashed
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> dictionary = new Dictionary<string, Dictionary<string, long>>();

            string singer = "";
            string place = "";
            string input = "";
            int ticketPrice = 0;
            long peopleCount = 0;
            long result = 0;
            Regex regex = new Regex(@"(\w+(?: \w+)*) @(\w+(?: \w+)*) (\d+) (\d+)");

            while ((input = Console.ReadLine()) != "End")
            {
                Match matcher = regex.Match(input);

                if (matcher.Success)
                {
                    singer = matcher.Groups[1].Value;
                    place = matcher.Groups[2].Value;
                    ticketPrice = int.Parse(matcher.Groups[3].Value);
                    peopleCount = long.Parse(matcher.Groups[4].Value);
                    result = ticketPrice * peopleCount;

                    if (!dictionary.ContainsKey(place))
                    {
                        Dictionary<string, long> innerDictionary = new Dictionary<string, long>();
                        innerDictionary.Add(singer, result);
                        dictionary.Add(place, innerDictionary);
                    }
                    else
                    {
                        if (!dictionary[place].ContainsKey(singer))
                        {
                            dictionary[place].Add(singer, result);
                        }
                        else
                        {
                            dictionary[place][singer] += result;
                        }
                    }
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
                foreach (var singers in dictionary[item.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singers.Key} -> {singers.Value}");
                }
            }
        }
    }
}
