using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr07SalesReport
{
    class Pr07SalesReport
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Sale[] sale = new Sale[n];
            for (int i = 0; i < n; i++)
            {
                sale[i] = readSale();
            }

            SortedDictionary<string, double> salesByTown = new SortedDictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                if (!salesByTown.ContainsKey(sale[i].town))
                {
                    salesByTown.Add(sale[i].town, 0);
                }

                salesByTown[sale[i].town] += sale[i].price * sale[i].quantity;
            }

            foreach (var item in salesByTown)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }

        private static Sale readSale()
        {
            string[] sale = Console.ReadLine().Split().ToArray();
            Sale singleSale = new Sale() { town = sale[0], product = sale[1], price = double.Parse(sale[2]), quantity = double.Parse(sale[3]) };
            return singleSale;
        }
    }

    class Sale
    {
        public string town { get; set; }
        public string product { get; set; }
        public double price { get; set; }
        public double quantity { get; set; }
    }
}
