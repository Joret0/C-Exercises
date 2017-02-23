using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            string[] array = Console.ReadLine().Split(' ');
            string extention = "." + array[0];
            string directory = array[2];
            Dictionary<string, long> dictionary = new Dictionary<string, long>();
            bool hasFound = false;
            for (int i = 0; i < list.Count; i++)
            {
                string[] info = list[i].Split(';').Select(x => x.Trim()).ToArray();
                long size = long.Parse(info[1]);
                string[] directoryInfo = info[0].Split('\\').Select(x => x.Trim()).ToArray();
                string folder = directoryInfo[0];
                string file = directoryInfo[directoryInfo.Length - 1];
                int index = file.IndexOf(extention);
                if (directory == folder && index != -1)
                {
                    if (!dictionary.ContainsKey(file))
                    {
                        dictionary.Add(file, size);
                    }
                    dictionary[file] = size;
                    hasFound = true;
                }
            }
            if (hasFound)
            {
                foreach (var file in dictionary.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
