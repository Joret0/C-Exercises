using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr04RoliTheCoder
{
    class Pr04RoliTheCoder
    {
        static void Main(string[] args)
        {
            Dictionary<int, Dictionary<string, List<string>>> events = new Dictionary<int, Dictionary<string, List<string>>>();
            string input = "";
            while ((input = Console.ReadLine()) != "Time for Code")
            {
                string[] info = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
                string hashTag = info[1];
                if (hashTag[0] == '#')
                {
                    string nameEvent = info[1].Substring(1);
                    int id = int.Parse(info[0]);
                    string[] people = info.Skip(2).ToArray();
                    List<string> particioiansList = new List<string>();
                    if (!events.ContainsKey(id))
                    {
                        for (int i = 0; i < people.Length; i++)
                        {
                            if (!particioiansList.Contains(people[i]))
                            {
                                string nameParticipian = people[i];
                                particioiansList.Add(nameParticipian);
                            }
                        }

                        Dictionary<string, List<string>> innerDictionary = new Dictionary<string, List<string>>();
                        innerDictionary.Add(nameEvent, particioiansList);
                        events.Add(id, innerDictionary);
                    }
                    else
                    {
                        if (events[id].ContainsKey(nameEvent))
                        {
                            for (int i = 0; i < people.Length; i++)
                            {
                                if (!events[id][nameEvent].Contains(people[i]))
                                {
                                    string nameParticipian = people[i];
                                    events[id][nameEvent].Add(nameParticipian);
                                }
                            }
                        }
                    }
                }
            }
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
            foreach (var item in events)
            {
                foreach (var dict in item.Value)
                {
                    result.Add(dict.Key, dict.Value);
                }
            }

            foreach (var id in result.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{id.Key} - {id.Value.Count()}");
                foreach (var name in id.Value.OrderBy(x => x))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
