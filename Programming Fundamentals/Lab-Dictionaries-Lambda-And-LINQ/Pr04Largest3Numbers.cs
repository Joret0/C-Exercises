using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr04Largest3Numbers
{
    class Pr04Largest3Numbers
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.WriteLine(string.Join(" ", list.OrderByDescending(x => x).Take(3)));
        }
    }
}
