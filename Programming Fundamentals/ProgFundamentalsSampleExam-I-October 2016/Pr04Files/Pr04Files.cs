using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pr04Files
{
    class Pr04Files
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }

            string[] filesToFind = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string directoryToMatch = filesToFind[2];
            string fileFormatToMatch = "." + filesToFind[0];

            List<string> listOfMatches = new List<string>();
            bool hasFound = false;
            for (int i = 0; i < list.Count; i++)
            {
                string[] array = list[i].Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string directory = array[0];
                string lastDirectoryInfo = array[array.Length - 1];

                if (directoryToMatch == directory && lastDirectoryInfo.IndexOf(fileFormatToMatch) != -1)
                {
                    listOfMatches.Add(lastDirectoryInfo);
                    hasFound = true;
                }
            }
            if (hasFound)
            {
                Dictionary<string, long> dictionary = new Dictionary<string, long>();

                for (int i = 0; i < listOfMatches.Count; i++)
                {
                    string[] fileInfo = listOfMatches[i].Split(';').Select(x => x.Trim()).ToArray();
                    string file = fileInfo[0];
                    long fileSize = long.Parse(fileInfo[1]);
                    if (!dictionary.ContainsKey(file))
                    {
                        dictionary.Add(file, fileSize);
                    }
                    else
                    {
                        dictionary[file] = fileSize;
                    }
                }

                foreach (var item in dictionary.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{item.Key} - {item.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
