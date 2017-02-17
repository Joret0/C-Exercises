using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr03TextFilter
{
    class Pr03TextFilter
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string text = Console.ReadLine();

            foreach (var banword in banWords)
            {
                text = text.Replace(banword, new string('*', banword.Length));
            }

            Console.WriteLine(text);
        }
    }
}
