using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr03RageQuit
{
    class Pr03RageQuit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            StringBuilder sb = new StringBuilder();
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    if (i + 1 < input.Length && char.IsDigit(input[i + 1]))
                    {
                        string nums = "";
                        for (int j = i; j < input.Length; j++)
                        {
                            if (!char.IsDigit(input[j]))
                            {
                                break;
                            }
                            else
                            {
                                nums += input[j];
                            }
                        }
                        int num = int.Parse(nums);
                        string letters = input.Substring(count, i - count);
                        count = i + nums.Length;
                        for (int j = 0; j < num; j++)
                        {
                            sb.Append(letters);
                        }
                        i += nums.Length - 1;
                    }
                    else
                    {
                        int number = int.Parse(input[i].ToString());
                        string leters = input.Substring(count, i - count);
                        count = i + 1;
                        for (int j = 0; j < number; j++)
                        {
                            sb.Append(leters);
                        }
                    }
                }
            }
            int symbolsCount = sb.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {symbolsCount}");
            Console.WriteLine(sb.ToString());
        }
    }
}
