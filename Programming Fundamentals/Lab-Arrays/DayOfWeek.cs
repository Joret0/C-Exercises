using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] array = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (n > 0 && n <= array.Length)
            {
                Console.WriteLine(array[n - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
