using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr07PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            string numbers = String.Join(", ", FindPrimesInRange(start, end).ToArray());
            Console.WriteLine(numbers);
        }

        private static List<int> FindPrimesInRange(int start, int end)
        {

            List<int> resultList = new List<int>();

            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;
                if (i < 2)
                {
                    isPrime = false;
                }
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    resultList.Add(i);
                }
            }
            return resultList;
        }
    }
}
