using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr01SweetDessert
{
    class Pr01SweetDessert
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            decimal guests = decimal.Parse(Console.ReadLine());
            double bananasPrice = double.Parse(Console.ReadLine());
            double eggsPrice = double.Parse(Console.ReadLine());
            double berriesPrice = double.Parse(Console.ReadLine());

            int portion = (int)Math.Ceiling(guests / 6);

            double neededCash = portion * (2 * bananasPrice) + portion * (4 * eggsPrice) + portion * (0.2 * berriesPrice);

            if (cash >= neededCash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {neededCash:f2}lv.");
            }
            else
            {
                double difference = Math.Abs(cash - neededCash);
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {difference:f2}lv more.");
            }
        }
    }
}
