using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr04FixEmails
{
    class Pr04FixEmails
    {
        static void Main(string[] args)
        {
            Dictionary<String, string> dictionary = new Dictionary<string, string>();
            string input = "";
            string prevInput = "";
            int count = 0;
            while ((input = Console.ReadLine()) != "stop")
            {
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

            foreach (var item in dictionary)
            {

                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
