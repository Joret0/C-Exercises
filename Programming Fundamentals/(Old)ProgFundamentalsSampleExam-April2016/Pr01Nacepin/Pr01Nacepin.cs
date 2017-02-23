using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr01Nacepin
{
    class Pr01Nacepin
    {
        static void Main(string[] args)
        {
            double usdPrice = double.Parse(Console.ReadLine());
            long boxUS = long.Parse(Console.ReadLine());
            double gbpPrice = double.Parse(Console.ReadLine());
            long boxUK = long.Parse(Console.ReadLine());
            double uanPrice = double.Parse(Console.ReadLine());
            long boxChina = long.Parse(Console.ReadLine());
            decimal USPriceInLeva = (decimal)(usdPrice / 0.58) / boxUS;
            decimal UKPRiceInLeva = (decimal)(gbpPrice / 0.41) / boxUK;
            decimal ChinaPriceInleva = (decimal)(uanPrice * 0.27) / boxChina;
            decimal biggestPrice = 0;
            decimal lowestPrice = 0;
            string country = "";
            if (USPriceInLeva > UKPRiceInLeva && USPriceInLeva > ChinaPriceInleva)
            {
                biggestPrice = USPriceInLeva;
            }
            else if (UKPRiceInLeva > USPriceInLeva && UKPRiceInLeva > ChinaPriceInleva)
            {
                biggestPrice = UKPRiceInLeva;
            }
            else
            {
                biggestPrice = ChinaPriceInleva;
            }
            if (USPriceInLeva < UKPRiceInLeva && USPriceInLeva < ChinaPriceInleva)
            {
                lowestPrice = USPriceInLeva;
                country = "US";
            }
            else if (UKPRiceInLeva < USPriceInLeva && UKPRiceInLeva < ChinaPriceInleva)
            {
                lowestPrice = UKPRiceInLeva;
                country = "UK";
            }
            else
            {
                lowestPrice = ChinaPriceInleva;
                country = "Chinese";
            }
            decimal difference = biggestPrice - lowestPrice;
            Console.WriteLine($"{country} store. {lowestPrice:f2} lv/kg");
            Console.WriteLine($"Difference {difference:f2} lv/kg");
        }
    }
}
