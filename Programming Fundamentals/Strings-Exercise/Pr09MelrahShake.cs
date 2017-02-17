using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr09MelrahShake
{
    class Pr09MelrahShake
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string key = Console.ReadLine();

            while (true)
            {
                int lastIndex = text.LastIndexOf(key);
                int firstIndex = text.IndexOf(key);

                if (firstIndex != -1 && lastIndex != -1 && firstIndex != lastIndex && key.Length > 0)
                {
                    Console.WriteLine("Shaked it.");
                    text = text.Remove(firstIndex, key.Length);
                    lastIndex = text.LastIndexOf(key);
                    text = text.Remove(lastIndex, key.Length);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(text);
                    break;
                }
                int indexToRemove = key.Length / 2;
                key = key.Remove(indexToRemove, 1);
            }
        }
    }
}
