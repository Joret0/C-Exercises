using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr07MultiplyBigNumber
{
    class Pr07MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());
            int res = 0;
            int toAdd = 0;

            StringBuilder sb = new StringBuilder();

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                res = num2 * int.Parse(num1[i].ToString()) + toAdd;
                if (res > 9)
                {
                    if (i == 0)
                    {
                        sb.Append(res % 10);
                        sb.Append(res / 10);
                    }
                    else
                    {
                        toAdd = res / 10;
                        res = res % 10;
                        sb.Append(res);
                    }
                }
                else
                {
                    toAdd = 0;
                    sb.Append(res);
                }
            }
            var result = new string(sb.ToString().ToCharArray().Reverse().ToArray()).TrimStart('0');
            bool flagZero = true;

            foreach (var item in result)
            {
                if (item != '0')
                {
                    flagZero = false;
                }
            }
            if (flagZero)
            {
                result = "0";
            }
            Console.WriteLine(result);
        }
    }
}
