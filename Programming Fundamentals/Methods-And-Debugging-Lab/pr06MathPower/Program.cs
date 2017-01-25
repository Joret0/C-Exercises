using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr06MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(ReiseToPower(number, power));
        }
        private static double ReiseToPower(double number, int power)
        {
            double result = Math.Pow(number, power);
            return result;
        }
    }
}
