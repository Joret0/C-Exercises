using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr02AppendLists
{
    class Pr02AppendLists
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split('|').ToList();
            items.Reverse();
            
            string currentLine = "";

            foreach (var item in items)
            {
                currentLine += " " + item;

            }
            char[] separator = new char[] { ' ', ',', '!', '.' };
            List<int> integers = currentLine.Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string result = string.Join(" ", integers.Select(n => n.ToString()));
            Console.WriteLine(result);
        }
    }
}
