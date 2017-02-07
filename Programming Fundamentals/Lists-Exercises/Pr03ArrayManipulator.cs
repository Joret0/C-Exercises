using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr03ArrayManipulator
{
    class Pr03ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            String line;
            while ((line = Console.ReadLine()) != "print")
            {
                string[] array = line.Split(' ');
                if (array[0] == "add")
                {
                    int index = int.Parse(array[1]);
                    int value = int.Parse(array[2]);
                    integers.Insert(index, value);
                }
                else if (array[0] == "addMany")
                {
                    int index = int.Parse(array[1]);
                    int[] tempArray = new int[array.Length - 2];
                    for (int i = 2; i < array.Length; i++)
                    {
                        tempArray[i - 2] = int.Parse(array[i]);
                    }
                    integers.InsertRange(index, tempArray);
                }
                else if (array[0] == "contains")
                {
                    int value = int.Parse(array[1]);
                    if (integers.Contains(value))
                    {
                        Console.WriteLine(integers.IndexOf(value));
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if (array[0] == "remove")
                {
                    int index = int.Parse(array[1]);
                    integers.RemoveAt(index);
                }
                else if (array[0] == "shift")
                {
                    int rotateStep = int.Parse(array[1]);
                    for (int i = 0; i < rotateStep; i++)
                    {
                        int first = integers[0];
                        integers.RemoveAt(0);
                        integers.Add(first);
                    }

                }
                else if (array[0] == "sumPairs")
                {
                    for (int i = 1; i < integers.Count; i++)
                    {
                        integers[i - 1] = integers[i] + integers[i - 1];
                        integers.RemoveAt(i);
                    }
                }
            }
            Console.Write($"[{string.Join(", ", integers)}]");
        }
    }
}
