using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentalsSampleExamIIOctober2016
{
    class Pr01SweetDessert
    {
        static void Main(string[] args)
        {
            double amountOfCash = double.Parse(Console.ReadLine());
            decimal NumberOfguests = int.Parse(Console.ReadLine());
            double bananasPrice = double.Parse(Console.ReadLine());
            double eggsPrice = double.Parse(Console.ReadLine());
            double berriesPrice = double.Parse(Console.ReadLine());

            int portions = (int)Math.Ceiling(NumberOfguests / 6);
            double costs = portions * ((2 * bananasPrice) + (4 * eggsPrice) + (0.20 * berriesPrice));

            if (amountOfCash >= costs)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {costs:f2}lv.");
            }
            else
            {
                double difference = Math.Abs(costs - amountOfCash);
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {difference:f2}lv more.");
            }
        }
    }
}
