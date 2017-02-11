using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pr05AMinerTask
{
    class Pr05AMinerTask
    {
        static void Main(string[] args)
        {
            Dictionary<String, int> dictionary = new Dictionary<string, int>();
            string[] array = File.ReadAllLines("input.txt");

            string prevInput = "";
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                string input = array[i];

                if (input == "stop")
                {
                    break;
                }

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

            string[] result = dictionary.Select(x => $"{x.Key} -> {x.Value}").ToArray();

            File.WriteAllLines("output.txt", result);
        }
    }
}
