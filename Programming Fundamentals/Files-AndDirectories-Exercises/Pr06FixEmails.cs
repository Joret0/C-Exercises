using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pr06FixEmails
{
    class Pr06FixEmails
    {
        static void Main(string[] args)
        {
            Dictionary<String, string> dictionary = new Dictionary<string, string>();
            string[] arrayInfo = File.ReadAllLines("input.txt").ToArray();

            string input = "";
            string prevInput = "";
            int count = 0;
            for (int i = 0; i < arrayInfo.Length; i++)
            {
                input = arrayInfo[i];

                if (input == "stop")
                {
                    break;
                }

                if (count % 2 == 0)
                {
                    if (!dictionary.ContainsKey(input))
                    {
                        dictionary.Add(input, "");
                        prevInput = input;
                    }
                }
                else
                {
                    char[] array = input.Reverse().Take(2).ToArray();
                    string domain = new string(array);

                    if (domain == "gb")
                    {
                        dictionary[prevInput] = input;
                    }
                    else
                    {
                        dictionary.Remove(prevInput);
                    }
                }
                count++;
            }

            var result = dictionary.Select(x => $"{x.Key} -> {x.Value}").ToArray();

            File.WriteAllLines("output.txt", result);
        }
    }
}
