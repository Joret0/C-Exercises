using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr05BombNumbers
{
    class Pr05BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int specialN = bomb[0];
            int power = bomb[1];
            while (nums.Contains(specialN))
            {
                int indexSpecialN = nums.IndexOf(specialN);
                for (int num = indexSpecialN - power; num <= indexSpecialN + power; num++)
                {
                    if (num >= 0 && num < nums.Count)
                    {
                        nums[num] = 0;
                    }
                }
            }
            Console.WriteLine(nums.Sum());
        }
    }
}
