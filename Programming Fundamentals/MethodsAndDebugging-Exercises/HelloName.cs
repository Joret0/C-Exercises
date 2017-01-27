using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr01HelloName
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            SayName(name);
        }

        private static void SayName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
