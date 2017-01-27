using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr10CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string property = Console.ReadLine();

            double result = AccountProperty(side, property);
            Console.WriteLine("{0:f2}", result);
        }

        private static double AccountProperty(double side, string property)
        {
            double result = 0.0;
            if (property == "area")
            {
                result = 6 * Math.Pow(side, 2);
            }
            else if (property == "space")
            {
                result = Math.Sqrt(3 * Math.Pow(side, 2));
            }
            else if (property == "volume")
            {
                result = Math.Pow(side, 3);
            }
            else if (property == "face")
            {
                result = Math.Sqrt(2 * Math.Pow(side, 2));
            }

            return result;
        }
    }
}
