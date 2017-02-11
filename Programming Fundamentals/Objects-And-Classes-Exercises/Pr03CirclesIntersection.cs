using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr03CirclesIntersection
{
    class Pr03CirclesIntersection
    {
        static void Main(string[] args)
        {
            Circle firstCircle = ReadCircle();
            Circle secondCircle = ReadCircle();

            bool doesIntersect = DoesIntersect(firstCircle, secondCircle);

            PrintResult(doesIntersect);
        }

        private static void PrintResult(bool doesIntersect)
        {
            if (doesIntersect)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static bool DoesIntersect(Circle first, Circle second)
        {
            double distance = CalcDistance(first.Center, second.Center);

            if (distance <= first.Radius + second.Radius)
            {
                return true;
            }

            return false;
        }

        private static Circle ReadCircle()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Circle circle = new Circle();
            circle.Center = new Point();
            circle.Center.X = input[0];
            circle.Center.Y = input[1];
            circle.Radius = input[2];

            return circle;
        }

        private static double CalcDistance(Point p1, Point p2)
        {
            int sideA = p1.X - p2.X;
            int sideB = p1.Y - p2.Y;
            double distance = Math.Sqrt(sideA * sideA + sideB * sideB);
            return distance;
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
        public double Area => Math.PI * Radius * Radius;
    }
}
