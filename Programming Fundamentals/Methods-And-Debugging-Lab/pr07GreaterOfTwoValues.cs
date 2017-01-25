using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr07GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int result = GetMax(first, second);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char result = GetMax(first, second);
                Console.WriteLine(result);
            }
            else
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string result = GetMax(first, second);
                Console.WriteLine(result);
            }
        }

        private static int GetMax(int first, int second)
        {
            int result;
            if (first > second)
            {
                result = first;
            }
            else
            {
                result = second;
            }

            return result;
        }

        private static char GetMax(char first, char second)
        {
            char result;
            if (first > second)
            {
                result = first;
            }
            else
            {
                result = second;
            }

            return result;
        }

        private static string GetMax(string first, string second)
        {
            string result;
            if (first.CompareTo(second) >= 0)
            {
                result = first;
            }
            else
            {
                result = second;
            }

            return result;
        }
    }
}
