using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr01SoftUniAirline
{
    class Pr01SoftUniAirline
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<decimal> allProfits = new List<decimal>();
            for (int i = 0; i < n; i++)
            {
                int adultCount = int.Parse(Console.ReadLine());
                decimal adultTicketPrice = decimal.Parse(Console.ReadLine());
                int youthCount = int.Parse(Console.ReadLine());
                decimal youthTicketPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPrice = decimal.Parse(Console.ReadLine());
                decimal fuelConsumation = decimal.Parse(Console.ReadLine());
                int flightDuration = int.Parse(Console.ReadLine());

                decimal income = (adultCount * adultTicketPrice) + (youthCount * youthTicketPrice);
                decimal expenses = flightDuration * fuelConsumation * fuelPrice;
                decimal profit = income - expenses;
                allProfits.Add(profit);

                if (profit >= 0)
                {
                    Console.WriteLine($"You are ahead with {profit:f3}$.");
                }
                else
                {
                    Console.WriteLine($"We've got to sell more tickets! We've lost {profit:f3}$.");
                }
            }
            decimal average = allProfits.Average();
            decimal totalProfit = allProfits.Sum();
            Console.WriteLine($"Overall profit -> {totalProfit:f3}$.");
            Console.WriteLine($"Average profit -> {average:f3}$.");
        }
    }
}
