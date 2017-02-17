using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr03EnduranceRally
{
    class Pr03EnduranceRally
    {
        static void Main(string[] args)
        {
            string[] players = Console.ReadLine().Split(' ');
            double[] zones = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] positions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<string> output = new List<string>();
            
            
            for (int i = 0; i < players.Length; i++)
            {
                double fuel = players[i][0];
                int indexEnd = -1;
                string player = players[i];

                for (int j = 0; j < zones.Length; j++)
                {
                    if (positions.Contains(j))
                    {
                        fuel += zones[j];
                    }
                    else
                    {
                        fuel -= zones[j];
                    }
                    if (fuel <= 0)
                    {
                        indexEnd = j;
                        break;
                    }
                }
                string result = "";

                if (fuel > 0)
                {
                    result = $"{player} - fuel left {fuel:f2}";
                }
                else
                {
                    result = $"{player} - reached {indexEnd}";
                }

                output.Add(result);
            }
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
