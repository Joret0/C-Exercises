using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr01CharityMarathon
{
    class Pr01CharityMarathon
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            long runners = int.Parse(Console.ReadLine());
            int laps = int.Parse(Console.ReadLine());
            int meters = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double moneyPerKm = double.Parse(Console.ReadLine());

            long maximumRunners = capacity * days;
            double totalKm = 0;
            double moneyRaised = 0;
            if (runners <= maximumRunners)
            {
                totalKm = (runners * laps * meters) / 1000;
                moneyRaised = totalKm * moneyPerKm;
            }
            else
            {
                totalKm = (maximumRunners * laps * meters) / 1000;
                moneyRaised = totalKm * moneyPerKm;
            }

            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}
