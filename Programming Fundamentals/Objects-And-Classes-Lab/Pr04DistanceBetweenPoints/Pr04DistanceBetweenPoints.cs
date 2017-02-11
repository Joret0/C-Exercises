using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr04DistanceBetweenPoints
{
    class Pr04DistanceBetweenPoints
    {
        static void Main(string[] args)
        {
            double[] info = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Point firstPoint = new Point();
            firstPoint.X = info[0];
            firstPoint.Y = info[1];

            double[] info2 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Point secondPoint = new Point();
            secondPoint.X = info2[0];
            secondPoint.Y = info2[1];
            double result = CalcDistance(firstPoint, secondPoint);
            Console.WriteLine("{0:f3}", result);
        }
        private static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            double deltaX = secondPoint.X - firstPoint.X;
            double deltaY = secondPoint.Y - firstPoint.Y;
            return Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
        }
    }
}
