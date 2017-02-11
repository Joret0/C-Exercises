using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pr03WordCount
{
    class Pr03WordCount
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split();
            string[] text = File.ReadAllText("text.txt")
                .ToLower()
                .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' },
                StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                wordCount.Add(word, 0);
            }

            foreach (var word in text)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
            }

            var sortedResult = wordCount
                .OrderByDescending(x => x.Value)
                .Select(x => $"{x.Key} - {x.Value}")
                .ToArray();

            File.WriteAllLines("output.txt", sortedResult);
        }
    }
}
