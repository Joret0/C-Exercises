using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr09.LongerLine
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            CheckDistance(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        private static double Distance(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return distance;
        }

        private static void CheckDistance(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double distancePoint1 = Distance(x1, y1);
            double distancePoint2 = Distance(x2, y2);
            double distancePoint3 = Distance(x3, y3);
            double distancePoint4 = Distance(x4, y4);

            double lenghtPointFirst = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            double lenghtPointSecond = Math.Sqrt(Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2));

            if (lenghtPointFirst >= lenghtPointSecond)
            {
                if (distancePoint1 <= distancePoint2)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else if (lenghtPointFirst < lenghtPointSecond)
            {
                if (distancePoint3 <= distancePoint4)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }
    }
}
