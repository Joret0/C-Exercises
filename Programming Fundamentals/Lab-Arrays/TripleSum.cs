using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4TripleSum
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');

            int[] nums = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                nums[i] = int.Parse(array[i]);
            }

            bool containSum = false;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    foreach (var item in nums)
                    {
                        if (nums[i] + nums[j] == item)
                        {
                            Console.Write($"{nums[i]} + {nums[j]} == {item}\n");
                            containSum = true;
                            break;
                        }
                    }
                }
            }
            if (!containSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
