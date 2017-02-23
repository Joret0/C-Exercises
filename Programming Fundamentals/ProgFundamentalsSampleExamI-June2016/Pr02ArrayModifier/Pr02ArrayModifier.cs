using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr02ArrayModifier
{
    class Pr02ArrayModifier
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string input = "";

            while ((input = Console.ReadLine()) != "end")
            {
                string[] info = input.Split(' ');
                string command = info[0];
                switch (command)
                {
                    case "swap":
                        int first = int.Parse(info[1]);
                        int second = int.Parse(info[2]);
                        long temp = array[first];
                        array[first] = array[second];
                        array[second] = temp;
                        break;
                    case "multiply":
                        int firstIndex = int.Parse(info[1]);
                        int secondIndex = int.Parse(info[2]);
                        array[firstIndex] = array[firstIndex] * array[secondIndex];
                        break;
                    case "decrease":
                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i] -= 1;
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
