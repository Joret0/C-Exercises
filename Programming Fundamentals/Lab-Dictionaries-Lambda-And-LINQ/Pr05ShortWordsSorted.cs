using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr05ShortWordsSorted
{
    class Pr05ShortWordsSorted
    {
        static void Main(string[] args)
        {
            char[] separator = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' ' };
            string[] words = Console.ReadLine().ToLower().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            var result = words.Where(x => x.Length < 5).Distinct().OrderBy(x => x);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
