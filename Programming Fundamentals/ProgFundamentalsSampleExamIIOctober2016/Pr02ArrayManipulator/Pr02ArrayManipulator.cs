using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr02ArrayManipulator
{
    class Pr02ArrayManipulator
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                string[] infoCommands = input.Split(' ');
                string command = infoCommands[0];
                if (command == "exchange")
                {
                    int index = int.Parse(infoCommands[1]);
                    if (index >= array.Length || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        int[] first = array.Take(index + 1).ToArray();
                        int[] second = array.Skip(index + 1).ToArray();
                        array = second.Concat(first).ToArray();
                    }
                }
                else if (command == "max")
                {
                    string evenOdd = infoCommands[1];
                    int index = 0;
                    bool hasFound = false;
                    if (evenOdd == "even")
                    {
                        int num = int.MinValue;
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] % 2 == 0)
                            {
                                if (array[i] >= num)
                                {
                                    num = array[i];
                                    index = i;
                                    hasFound = true;
                                }
                            }
                        }
                        if (hasFound)
                        {
                            Console.WriteLine(index);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else
                    {
                        int num = int.MinValue;
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] % 2 != 0)
                            {
                                if (array[i] >= num)
                                {
                                    num = array[i];
                                    index = i;
                                    hasFound = true;
                                }
                            }
                        }
                        if (hasFound)
                        {
                            Console.WriteLine(index);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }
                else if (command == "min")
                {
                    string evenOdd = infoCommands[1];
                    int index = 0;
                    bool hasFound = false;
                    if (evenOdd == "even")
                    {
                        int num = int.MaxValue;
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] % 2 == 0)
                            {
                                if (array[i] <= num)
                                {
                                    num = array[i];
                                    index = i;
                                    hasFound = true;
                                }
                            }
                        }
                        if (hasFound)
                        {
                            Console.WriteLine(index);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else
                    {
                        int num = int.MaxValue;
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] % 2 != 0)
                            {
                                if (array[i] <= num)
                                {
                                    num = array[i];
                                    index = i;
                                    hasFound = true;
                                }
                            }
                        }
                        if (hasFound)
                        {
                            Console.WriteLine(index);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                }
                else if (command == "first")
                {
                    int count = int.Parse(infoCommands[1]);
                    string evenOdd = infoCommands[2];
                    if (count > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (evenOdd == "even")
                        {
                            List<int> list = new List<int>();
                            int num = 0;
                            for (int i = 0; i < array.Length; i++)
                            {
                                if (array[i] % 2 == 0)
                                {
                                    list.Add(array[i]);
                                    num++;
                                    if (num == count)
                                    {
                                        break;
                                    }
                                }
                            }
                            if (list.Count == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine("[{0}]", string.Join(", ", list));
                            }
                        }
                        else
                        {
                            List<int> list = new List<int>();
                            int num = 0;
                            for (int i = 0; i < array.Length; i++)
                            {
                                if (array[i] % 2 != 0)
                                {
                                    list.Add(array[i]);
                                    num++;
                                    if (num == count)
                                    {
                                        break;
                                    }
                                }
                            }
                            Console.WriteLine("[{0}]", string.Join(", ", list));
                        }
                    }
                }
                else if (command == "last")
                {
                    int count = int.Parse(infoCommands[1]);
                    string evenOdd = infoCommands[2];
                    if (count > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (evenOdd == "even")
                        {
                            List<int> list = new List<int>();
                            int num = 0;
                            for (int i = array.Length - 1; i >= 0; i--)
                            {
                                if (array[i] % 2 == 0)
                                {
                                    list.Add(array[i]);
                                    num++;
                                    if (num == count)
                                    {
                                        break;
                                    }
                                }
                            }
                            if (list.Count == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                list.Reverse();
                                Console.WriteLine("[{0}]", string.Join(", ", list));
                            }
                        }
                        else
                        {
                            List<int> list = new List<int>();
                            int num = 0;
                            for (int i = array.Length - 1; i >= 0; i--)
                            {
                                if (array[i] % 2 != 0)
                                {
                                    list.Add(array[i]);
                                    num++;
                                    if (num == count)
                                    {
                                        break;
                                    }
                                }
                            }
                            list.Reverse();
                            Console.WriteLine("[{0}]", string.Join(", ", list));
                        }
                    }
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }
    }
}
