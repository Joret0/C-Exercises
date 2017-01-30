using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr05CompareCharArrays
{
    class Pr05CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            bool areDifferent = false;

            if (firstArray.Length < secondArray.Length)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    Console.Write(firstArray[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < secondArray.Length; i++)
                {
                    Console.Write(secondArray[i]);
                }
                Console.WriteLine();
            }
            else if (secondArray.Length < firstArray.Length)
            {
                for (int i = 0; i < secondArray.Length; i++)
                {
                    Console.Write(secondArray[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < firstArray.Length; i++)
                {
                    Console.Write(firstArray[i]);
                }
                Console.WriteLine();
            }
            else if (firstArray.Length == secondArray.Length)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        areDifferent = true;
                        break;
                    }
                }

                if (areDifferent)
                {
                    for (int i = 0; i < firstArray.Length; i++)
                    {
                        if (firstArray[i] < secondArray[i])
                        {
                            for (int j = 0; j < firstArray.Length; j++)
                            {
                                Console.Write(firstArray[j]);
                            }
                            Console.WriteLine();
                            for (int j = 0; j < secondArray.Length; j++)
                            {
                                Console.Write(secondArray[j]);
                            }
                            Console.WriteLine();
                            break;
                        }
                        else if (firstArray[i] > secondArray[i])
                        {
                            for (int j = 0; j < secondArray.Length; j++)
                            {
                                Console.Write(secondArray[j]);
                            }
                            Console.WriteLine();
                            for (int j = 0; j < firstArray.Length; j++)
                            {
                                Console.Write(firstArray[j]);
                            }
                            Console.WriteLine();
                            break;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < firstArray.Length; j++)
                    {
                        Console.Write(firstArray[j]);
                    }
                    Console.WriteLine();
                    for (int j = 0; j < secondArray.Length; j++)
                    {
                        Console.Write(secondArray[j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
