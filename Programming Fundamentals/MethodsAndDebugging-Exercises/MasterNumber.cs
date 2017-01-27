using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr12MasterNumber
{
    class MasterNumber
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int number = int.Parse(input);

            for (int i = 1; i <= number; i++)
            {
                if (isPalindrome(i) == true && isDivisibleSum(i) == true && hasOneEvenDigit(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool hasOneEvenDigit(int input)
        {
            bool hasEvenDigit = false;
            string number = input.ToString();

            int evenCounter = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int digit = int.Parse(number[i].ToString());

                if (digit % 2 == 0)
                {
                    evenCounter++;
                }
            }

            if (evenCounter > 0)
            {
                hasEvenDigit = true;
            }
            else
            {
                hasEvenDigit = false;
            }

            return hasEvenDigit;
        }

        private static bool isDivisibleSum(int input)
        {
            bool divisible = false;
            string number = input.ToString();
            int sumOfDigits = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sumOfDigits += int.Parse(number[i].ToString());
            }

            if (sumOfDigits % 7 == 0)
            {
                divisible = true;
            }
            else
            {
                divisible = false;
            }

            return divisible;
        }

        private static bool isPalindrome(int input)
        {
            bool palindome = true;
            string number = input.ToString();

            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] != number[number.Length - 1 - i])
                {
                    palindome = false;
                }
            }
            return palindome;
        }
    }
}
