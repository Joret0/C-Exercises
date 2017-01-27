using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr11GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double parameter1 = 0.0;
            double parameter2 = 0.0;

            if (shape == "triangle")
            {
                parameter1 = double.Parse(Console.ReadLine());
                parameter2 = double.Parse(Console.ReadLine());
            }
            else if (shape == "square")
            {
                parameter1 = double.Parse(Console.ReadLine());
            }
            else if (shape == "rectangle")
            {
                parameter1 = double.Parse(Console.ReadLine());
                parameter2 = double.Parse(Console.ReadLine());
            }
            else if (shape == "circle")
            {
                parameter1 = double.Parse(Console.ReadLine());
            }

            double result = AcountParameters(shape, parameter1, parameter2);
            Console.WriteLine("{0:f2}", result);
        }

        private static double AcountParameters(string shape, double parameter1, double parameter2)
        {
            double result = 0.0;

            if (shape == "triangle")
            {
                result = (parameter1 * parameter2) / 2;
            }
            else if (shape == "square")
            {
                result = Math.Pow(parameter1, 2);
            }
            else if (shape == "rectangle")
            {
                result = parameter1 * parameter2;
            }
            else if (shape == "circle")
            {
                result = Math.PI * Math.Pow(parameter1, 2);
            }

            return result;
        }
    }
}
