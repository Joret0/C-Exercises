using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr05CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetTriangelArea(width, height);
            Console.WriteLine(area);
        }
        private static double GetTriangelArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
