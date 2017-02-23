using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Pr02SoftuniCoffeeOrders
{
    class Pr02SoftuniCoffeeOrders
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            DateTime date = new DateTime();
            decimal totalPrice = 0;
            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);
                long capsulesCount = int.Parse(Console.ReadLine());
                decimal price = ((daysInMonth * capsulesCount) * pricePerCapsule);
                totalPrice += price;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
