using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pr04CubicMessages
{
    class Pr04CubicMessages
    {
        static void Main(string[] args)
        {
            string scriptMessage = Console.ReadLine();
            var dictionary = new Dictionary<string, string>();

            while (!scriptMessage.Equals("Over!"))
            {
                int count = int.Parse(Console.ReadLine());

                string pattern = @"^([0-9]+)([a-zA-Z]{" + count + @"})([^a-zA-Z]*)$";

                Regex regex = new Regex(pattern);

                Match matchMessage = regex.Match(scriptMessage);

                if (matchMessage.Success)
                {
                    
                    string message = "";
                    string firstIndex = matchMessage.Groups[1].Value;
                    string letters = matchMessage.Groups[2].Value;
                    string secondIndex = matchMessage.Groups[3].Value;

                    for (int i = 0; i < firstIndex.Length; i++)
                    {
                        int index = int.Parse(firstIndex[i].ToString());
                        if (index < letters.Length && index >= 0)
                        {
                            message += letters[index];
                        }
                        else
                        {
                            message += " ";
                        }
                    }

                    for (int j = 0; j < secondIndex.Length; j++)
                    {
                        if (char.IsDigit(secondIndex[j]))
                        {
                            int index = int.Parse(secondIndex[j].ToString());
                            if (index < letters.Length && index >= 0)
                            {
                                message += letters[index];
                            }
                            else
                            {
                                message += " ";
                            }
                        }
                    }
                    dictionary.Add(letters, message);
                }
                scriptMessage = Console.ReadLine();
            }
            foreach (var messages in dictionary)
            {
                Console.WriteLine($"{messages.Key} == {messages.Value}");
            }
        }
    }
}
