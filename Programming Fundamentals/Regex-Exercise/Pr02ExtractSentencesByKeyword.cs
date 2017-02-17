using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pr02ExtractSentencesByKeyword
{
    class Pr02ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string[] text = Console.ReadLine()
                .Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            string pattern = $@"\b{key}\b";
            Regex regex = new Regex(pattern);

            foreach (var sentence in text)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence);
                }
            }
        }
    }
}
