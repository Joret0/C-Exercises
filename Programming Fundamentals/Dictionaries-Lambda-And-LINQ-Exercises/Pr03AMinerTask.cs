using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr03AMinerTask
{
    class Pr03AMinerTask
    {
        static void Main(string[] args)
        {
            Dictionary<String, int> dictionary = new Dictionary<string, int>();
            string input = "";
            string prevInput = "";
            int count = 0;
            while ((input = Console.ReadLine()) != "stop")
            {
                if (count % 2 == 0)
                {
                    if (!dictionary.ContainsKey(input))
                    {
                        dictionary.Add(input, 0);
                        prevInput = input;
                    }
                    else
                    {
                        prevInput = input;
                    }
                }
                else
                {
                    int value = int.Parse(input);
                    dictionary[prevInput] += value;
                }
                count++;
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
