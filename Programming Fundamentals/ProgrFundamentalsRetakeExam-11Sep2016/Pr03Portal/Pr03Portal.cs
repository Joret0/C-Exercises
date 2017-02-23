using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr03Portal
{
    class Pr03Portal
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            List<string> map = new List<string>();
            int currentRow = 0;
            int currentCol = 0;

            for (int i = 0; i < rowsCount; i++)
            {
                map.Add(Console.ReadLine());

                if (map[i].Contains("S"))
                {
                    currentRow = i;
                    currentCol = map[i].IndexOf("S");
                }
            }

            string commands = Console.ReadLine();
            int turns = 0;

            for (int i = 0; i < commands.Length; i++)
            {
                turns++;
                char currentMove = commands[i];

                switch (currentMove)
                {
                    case 'D':

                        while (true)
                        {
                            currentRow++;

                            // If the robot go outside of the map:
                            if (currentRow == map.Count)
                            {
                                currentRow = 0;
                                if (currentCol >= map[currentRow].Length)
                                {
                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            if (currentCol >= map[currentRow].Length)
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;

                    case 'U':

                        while (true)
                        {
                            currentRow--;
                            if (currentRow == -1)
                            {
                                currentRow = map.Count - 1;
                                if (currentCol >= map[currentRow].Length)
                                {
                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            if (currentCol >= map[currentRow].Length)
                            {
                                continue;
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;

                    case 'L':

                        currentCol--;
                        if (currentCol == -1)
                        {
                            currentCol = map[currentRow].Length - 1;
                        }
                        break;

                    case 'R':

                        currentCol++;
                        if (currentCol == map[currentRow].Length)
                        {
                            currentCol = 0;
                        }
                        break;
                }

                if (map[currentRow][currentCol].Equals('E'))
                {
                    Console.WriteLine($"Experiment successful. {turns} turns required.");
                    return;
                }
            }

            Console.WriteLine($"Robot stuck at {currentRow} {currentCol}. Experiment failed.");
        }
    }
}