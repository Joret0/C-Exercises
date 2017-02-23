using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr02SoftUniWaterSupplies
{
    class Pr02SoftUniWaterSupplies
    {
        static void Main(string[] args)
        {
            var totalWater = double.Parse(Console.ReadLine());
            var items = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var itemCapacity = double.Parse(Console.ReadLine());

            var usedWater = 0d;
            var indexes = new List<int>();
            var index = totalWater % 2 != 0 ? items.Length - 1 : 0;
            var count = 0;

            while (count < items.Length)
            {
                usedWater += itemCapacity - items[index];
                indexes.Add(usedWater > totalWater ? index : -1);
                count++;
                index += totalWater % 2 != 0 ? -1 : 1;
            }
            if (usedWater > totalWater)
            {
                indexes.RemoveAll(p => p == -1);
                Console.WriteLine("We need more water!");
                Console.WriteLine($"Bottles left: {indexes.Count}");
                Console.WriteLine($"With indexes: {string.Join(", ", indexes)}");
                Console.WriteLine($"We need {usedWater - totalWater} more liters!");
                return;
            }
            Console.WriteLine("Enough water!");
            Console.WriteLine($"Water left: {totalWater - usedWater}l.");
        }
    }
}
