using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr01Phonebook
{
    class Pr01Phonebook
    {
        static void Main(string[] args)
        {
            string input = "";
            Dictionary<string, string> dictonary = new Dictionary<string, string>();

            while ((input = Console.ReadLine()) != "END")
            {
                string[] array = input.Split(' ').ToArray();
                string comand = array[0];
                if (comand == "A")
                {
                    if (!dictonary.ContainsKey(array[1]))
                    {
                        dictonary.Add(array[1], array[2]);
                    }
                    else
                    {
                        dictonary[array[1]] = array[2];
                    }
                }
                else if (comand == "S")
                {
                    if (dictonary.ContainsKey(array[1]))
                    {
                        foreach (var item in dictonary)
                        {
                            if (item.Key == array[1])
                            {
                                Console.WriteLine($"{item.Key} -> {item.Value}");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Contact {array[1]} does not exist.");
                    }
                }
            }
        }
    }
}
