using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pr01ExtractEmails
{
    class Pr01ExtractEmails
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"([\w.-]+\@[a-zA-Z-]+)(\.[a-zA-Z-]+)+";
            Regex regex = new Regex(pattern);
            MatchCollection match = regex.Matches(text);
            
            foreach (Match item in match)
            {
                string matchStr = item.ToString();
                bool isMatch = matchStr.StartsWith("-") ||
                    matchStr.StartsWith(".") ||
                    matchStr.StartsWith("_") ||
                    matchStr.EndsWith("-") ||
                    matchStr.EndsWith(".") ||
                    matchStr.EndsWith("_");

                if (!isMatch)
                {
                    Console.WriteLine(matchStr);
                }
            }
        }
    }
}
