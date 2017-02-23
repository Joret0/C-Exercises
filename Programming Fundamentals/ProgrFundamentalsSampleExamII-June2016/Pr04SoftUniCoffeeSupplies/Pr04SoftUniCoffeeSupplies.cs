using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr04SoftUniCoffeeSupplies
{
    class Pr04SoftUniCoffeeSupplies
    {
        static void Main(string[] args)
        {
            var personCoffeeType = new Dictionary<string, string>();
            var coffeeTypeQuantity = new Dictionary<string, int>();

            string[] delimiters = Console.ReadLine().Split(' ');
            string input = "";
            while ((input = Console.ReadLine()) != "end of info")
            {
                int indexLeft = input.IndexOf(delimiters[0]);
                int indexRight = input.IndexOf(delimiters[1]);
                if (indexLeft != -1)
                {
                    string[] info = input.Split(new string[] { delimiters[0] }, StringSplitOptions.None);
                    string name = info[0];
                    string coffeeType = info[1];
                    personCoffeeType.Add(name, coffeeType);
                    if (!coffeeTypeQuantity.ContainsKey(coffeeType))
                    {
                        coffeeTypeQuantity.Add(coffeeType, 0);
                    }
                }
                else if (indexRight != -1)
                {
                    string[] info = input.Split(new string[] { delimiters[1] }, StringSplitOptions.None);
                    string coffeeType = info[0];
                    int quantity = int.Parse(info[1]);
                    if (!coffeeTypeQuantity.ContainsKey(coffeeType))
                    {
                        coffeeTypeQuantity.Add(coffeeType, quantity);
                    }
                    else
                    {
                        coffeeTypeQuantity[coffeeType] += quantity;
                    }
                }
            }
            string noneLeft = string.Empty;
            foreach (var coffee in coffeeTypeQuantity.Where(x => x.Value <= 0))
            {
                noneLeft += $"Out of {coffee.Key}\n";
            }
            input = "";
            while ((input = Console.ReadLine()) != "end of week")
            {
                string[] info = input.Split(' ');
                string name = info[0];
                int quantity = int.Parse(info[1]);
                string coffeeType = personCoffeeType[name];
                coffeeTypeQuantity[coffeeType] -= quantity;
                if (coffeeTypeQuantity[coffeeType] <= 0)
                {
                    noneLeft += $"Out of {coffeeType}\n";
                }
            }
            Console.Write(noneLeft);
            Console.WriteLine("Coffee Left:");
            List<string> coffeeLeft = new List<string>();
            foreach (var coffee in coffeeTypeQuantity.Where(x => x.Value > 0).OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{coffee.Key} {coffee.Value}");
                coffeeLeft.Add(coffee.Key);
            }
            Console.WriteLine("For:");
            foreach (var name in personCoffeeType.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
            {
                if (coffeeLeft.Contains(name.Value))
                {
                    Console.WriteLine($"{name.Key} {name.Value}");
                }
            }
        }
    }
}
