using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr05MagicExchangeableWords
{
    class Pr05MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string firstStr = input[0];
            string secondStr = input[1];
            var newStr1 = firstStr.Distinct().ToArray();
            var newStr2 = secondStr.Distinct().ToArray();
            if (newStr1.Length == newStr2.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
