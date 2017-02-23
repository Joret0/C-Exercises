using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr02TrophonTheGrumpyCat
{
    class Pr02TrophonTheGrumpyCat
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            int index = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine();
            string priceRating = Console.ReadLine();
            long sumRight = 0;
            for (int i = index + 1; i < array.Length; i++)
            {
                if (typeOfItems == "cheap")
                {
                    if (array[index] > array[i])
                    {
                        if (priceRating == "positive")
                        {
                            if (array[i] > 0)
                            {
                                sumRight += array[i];
                            }
                        }
                        else if (priceRating == "negative")
                        {
                            if (array[i] < 0)
                            {
                                sumRight += array[i];
                            }
                        }
                        else
                        {
                            sumRight += array[i];
                        }
                    }
                }
                else
                {
                    if (array[index] <= array[i])
                    {
                        if (priceRating == "positive")
                        {
                            if (array[i] > 0)
                            {
                                sumRight += array[i];
                            }
                        }
                        else if (priceRating == "negative")
                        {
                            if (array[i] < 0)
                            {
                                sumRight += array[i];
                            }
                        }
                        else
                        {
                            sumRight += array[i];
                        }
                    }
                }
            }

            long sumLeft = 0;

            for (int i = index - 1; i >= 0; i--)
            {
                if (typeOfItems == "cheap")
                {
                    if (array[index] > array[i])
                    {
                        if (priceRating == "positive")
                        {
                            if (array[i] > 0)
                            {
                                sumLeft += array[i];
                            }
                        }
                        else if (priceRating == "negative")
                        {
                            if (array[i] < 0)
                            {
                                sumLeft += array[i];
                            }
                        }
                        else
                        {
                            sumLeft += array[i];
                        }
                    }
                }
                else
                {
                    if (array[index] <= array[i])
                    {
                        if (priceRating == "positive")
                        {
                            if (array[i] > 0)
                            {
                                sumLeft += array[i];
                            }
                        }
                        else if (priceRating == "negative")
                        {
                            if (array[i] < 0)
                            {
                                sumLeft += array[i];
                            }
                        }
                        else
                        {
                            sumLeft += array[i];
                        }
                    }
                }
            }
            if (sumRight > sumLeft)
            {
                Console.WriteLine($"Right - {sumRight}");
            }
            else
            {
                Console.WriteLine($"Left - {sumLeft}");
            }
        }
    }
}
