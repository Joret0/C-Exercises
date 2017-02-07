using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr09LegendaryFarming
{
    class Pr09LegendaryFarming
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
            SortedDictionary<string, int> junkDictionary = new SortedDictionary<string, int>();
            dictionary.Add("shards", 0);
            dictionary.Add("fragments", 0);
            dictionary.Add("motes", 0);

            int shadowmourne = 0;
            int valanyr = 0;
            int dragonwrath = 0;
            bool isTrue = true;

            string input;

            while (isTrue)
            {

                string[] line = Console.ReadLine().ToLower().Split(' ').ToArray();

                string key = line[1];

                for (int i = 0; i < line.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        key = line[i];
                        if (key == "shards" || key == "fragments" || key == "motes")
                        {
                            
                            if (!dictionary.ContainsKey(key))
                            {
                                dictionary.Add(key, 0);
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            if (!junkDictionary.ContainsKey(key))
                            {
                                junkDictionary.Add(key, 0);
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else
                    {
                        int value = int.Parse(line[i]);
                        key = line[i + 1];
                        if (key == "shards" || key == "fragments" || key == "motes")
                        {
                            if (!dictionary.ContainsKey(key))
                            {
                                dictionary.Add(key, value);
                            }
                            else
                            {
                                dictionary[key] += value;
                            }

                            if (dictionary[key] >= 250 && key == "shards")
                            {
                                shadowmourne++;
                                dictionary[key] -= 250;
                                isTrue = false;
                                break;
                            }
                            else if (dictionary[key] >= 250 && key == "fragments")
                            {
                                valanyr++;
                                dictionary[key] -= 250;
                                isTrue = false;
                                break;
                            }
                            else if (dictionary[key] >= 250 && key == "motes")
                            {
                                dragonwrath++;
                                dictionary[key] -= 250;
                                isTrue = false;
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            if (!junkDictionary.ContainsKey(key))
                            {
                                junkDictionary.Add(key, value);
                            }
                            else
                            {
                                junkDictionary[key] += value;
                            }
                        }
                    }
                }
                
            }
            if (shadowmourne > 0)
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (valanyr > 0)
            {
                Console.WriteLine("Valanyr obtained!");
            }
            else if (dragonwrath > 0)
            {
                Console.WriteLine("Dragonwrath obtained!");
            }

            foreach (var item in dictionary.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkDictionary.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
