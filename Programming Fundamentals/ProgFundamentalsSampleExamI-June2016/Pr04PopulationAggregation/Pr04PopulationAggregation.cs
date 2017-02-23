using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pr04PopulationAggregation
{
    class Pr04PopulationAggregation
    {
        static void Main(string[] args)
        {
            var countries = new Dictionary<string, int>();
            var cities = new Dictionary<string, long>();

            string input = "";

            while ((input = Console.ReadLine()) != "stop")
            {
                string[] info = input.Split('\\');
                string firstWord = info[0];
                if (char.IsUpper(firstWord[0]))
                {
                    Regex regex = new Regex("[^a-zA-Z]");
                    string country = regex.Replace(firstWord, "");
                    string city = regex.Replace(info[1], "");
                    long population = long.Parse(info[2]);

                    if (!countries.ContainsKey(country))
                    {
                        countries.Add(country, 0);
                    }
                    countries[country]++;

                    if (!cities.ContainsKey(city))
                    {
                        cities.Add(city, 0);
                    }
                    cities[city] = population;
                }
                else
                {
                    Regex regex = new Regex("[^a-zA-Z]");
                    string city = regex.Replace(firstWord, "");
                    string country = regex.Replace(info[1], "");
                    long population = long.Parse(info[2]);

                    if (!countries.ContainsKey(country))
                    {
                        countries.Add(country, 0);
                    }
                    countries[country]++;

                    if (!cities.ContainsKey(city))
                    {
                        cities.Add(city, 0);
                    }
                    cities[city] = population;
                }
            }

            foreach (var country in countries.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{country.Key} -> {country.Value}");
            }
            foreach (var city in cities.OrderByDescending(x => x.Value).Take(3))
            {
                Console.WriteLine($"{city.Key} -> {city.Value}");
            }
        }
    }
}
