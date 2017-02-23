using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr02CommandInterpreter
{
    class Pr02CommandInterpreter
    {
        static void Main(string[] args)
        {
            List<string> listToManipulate = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            string[] arrayOfCommands = Console.ReadLine()
                    .Split(' ');
            List<string> currentList = new List<string>();

            while (arrayOfCommands[0] != "end")
            {
                if (arrayOfCommands[0] == "reverse")
                {
                    int indexFrom = int.Parse(arrayOfCommands[2]);
                    int indexTo = int.Parse(arrayOfCommands[4]);
                    if (indexFrom >= 0 && indexFrom < listToManipulate.Count && indexTo >= 0 && (indexFrom + indexTo) <= listToManipulate.Count)
                    {
                        listToManipulate.Reverse(indexFrom, indexTo);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (arrayOfCommands[0] == "sort")
                {
                    int indexFrom = int.Parse(arrayOfCommands[2]);
                    int indexTo = int.Parse(arrayOfCommands[4]);
                    if (indexFrom >= 0 && indexFrom < listToManipulate.Count && indexTo >= 0 && (indexFrom + indexTo) <= listToManipulate.Count)
                    {
                        currentList = listToManipulate.Skip(indexFrom).Take(indexTo).OrderBy(str => str).ToList();
                        listToManipulate.RemoveRange(indexFrom, indexTo);
                        listToManipulate.InsertRange(indexFrom, currentList);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (arrayOfCommands[0] == "rollLeft")
                {
                    int countTimes = int.Parse(arrayOfCommands[1]);
                    if (countTimes >= 0)
                    {
                        for (int i = 0; i < countTimes % listToManipulate.Count; i++)
                        {
                            string element = listToManipulate[0];
                            listToManipulate.RemoveAt(0);
                            listToManipulate.Add(element);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                else if (arrayOfCommands[0] == "rollRight")
                {
                    int countTimes = int.Parse(arrayOfCommands[1]);
                    if (countTimes >= 0)
                    {
                        for (int i = 0; i < countTimes % listToManipulate.Count; i++)
                        {
                            string element = listToManipulate[listToManipulate.Count - 1];
                            listToManipulate.RemoveAt(listToManipulate.Count - 1);
                            listToManipulate.Insert(0, element);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                }
                arrayOfCommands = Console.ReadLine()
                    .Split(' ');
            }

            Console.WriteLine("[{0}]", string.Join(", ", listToManipulate));
        }
    }
}
