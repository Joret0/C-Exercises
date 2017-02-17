using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr01SinoTheWalker
{
    class Pr01SinoTheWalker
    {
        static void Main(string[] args)
        {
            string inputDate = Console.ReadLine();
            int stepsToHome = int.Parse(Console.ReadLine()) % 86400;
            int secondsPerStep = int.Parse(Console.ReadLine()) % 86400;

            DateTime currentDate = DateTime.Parse(inputDate);
            long sumSeconds = stepsToHome * secondsPerStep;
            currentDate = currentDate.AddSeconds(sumSeconds);
            string output = currentDate.TimeOfDay.ToString();
            Console.WriteLine($"Time Arrival: {output}");
        }
    }
}
