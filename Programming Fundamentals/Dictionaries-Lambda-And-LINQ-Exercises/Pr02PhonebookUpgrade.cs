using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr02PhonebookUpgrade
{
    class Pr02PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            string input = "";
            SortedDictionary<string, string> dictonary = new SortedDictionary<string, string>();

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
                else if (comand == "ListAll")
                {
                    foreach (var item in dictonary)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
            }
        }
    }
}
