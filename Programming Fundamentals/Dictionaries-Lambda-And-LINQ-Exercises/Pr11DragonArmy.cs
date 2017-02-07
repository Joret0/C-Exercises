using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr11DragonArmy
{
    class Pr11DragonArmy
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedDictionary<string, List<double>>> dictionary = new Dictionary<string, SortedDictionary<string, List<double>>>();

            int n = int.Parse(Console.ReadLine());
            double damage = 0;
            double health = 0;
            double armor = 0;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string typeDragon = input[0];
                string dragonName = input[1];
                if (input[2] == "null")
                {
                    damage = 45;
                }
                else
                {
                    damage = double.Parse(input[2]);
                }
                if (input[3] == "null")
                {
                    health = 250;
                }
                else
                {
                    health = double.Parse(input[3]);
                }
                if (input[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = double.Parse(input[4]);
                }

                if (!dictionary.ContainsKey(typeDragon))
                {
                    SortedDictionary<string, List<double>> innerDictionary = new SortedDictionary<string, List<double>>();
                    List<double> list = new List<double>();
                    list.Add(damage);
                    list.Add(health);
                    list.Add(armor);
                    innerDictionary.Add(dragonName, list);
                    dictionary.Add(typeDragon, innerDictionary);
                }
                else
                {
                    if (!dictionary[typeDragon].ContainsKey(dragonName))
                    {
                        SortedDictionary<string, List<double>> innerDictionary = new SortedDictionary<string, List<double>>();
                        List<double> list = new List<double>();
                        list.Add(damage);
                        list.Add(health);
                        list.Add(armor);
                        dictionary[typeDragon].Add(dragonName, list);
                    }
                    else
                    {
                        List<double> list = new List<double>();
                        list.Add(damage);
                        list.Add(health);
                        list.Add(armor);
                        dictionary[typeDragon][dragonName] = list;
                    }
                }
            }

            foreach (var item in dictionary)
            {
                double damageSum = 0;
                double healthSum = 0;
                double armorSum = 0;

                foreach (var stats in dictionary[item.Key])
                {
                    damageSum += stats.Value[0];
                    healthSum += stats.Value[1];
                    armorSum += stats.Value[2];
                }
                int length = dictionary[item.Key].Values.Count();

                Console.WriteLine("{0}::({1:f2}/{2:f2}/{3:f2})", item.Key, damageSum / length, healthSum / length, armorSum / length);

                foreach (var dragon in dictionary[item.Key])
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}
