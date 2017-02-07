using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr07PopulationCounter
{
    class Pr07PopulationCounter
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> dictionary = new Dictionary<string, Dictionary<string, long>>();
            string input = "";

            while ((input = Console.ReadLine()) != "report")
            {
                string[] info = input.Split('|');
                string country = info[1];
                string city = info[0];
                long population = long.Parse(info[2]);

                if (!dictionary.ContainsKey(country))
                {
                    Dictionary<string, long> cityInfo = new Dictionary<string, long>();
                    cityInfo.Add(city, population);
                    dictionary.Add(country, cityInfo);

                }
                else
                {
                    if (!dictionary[country].ContainsKey(city))
                    {
                        dictionary[country].Add(city, population);
                    }
                    else
                    {
                        dictionary[country][city] += population;
                    }
                }
            }

            foreach (var item in dictionary.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                List<long> sumPopulation = item.Value.Select(x => x.Value).ToList();

                Console.WriteLine($"{item.Key} (total population: {sumPopulation.Sum()})");

                Console.Write($"=>{string.Join("=>", item.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value}\r\n"))}");
            }
        }
    }
}
