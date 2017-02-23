using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr04TrifonsQuest
{
    class Pr04TrifonsQuest
    {
        static void Main(string[] args)
        {
            long health = long.Parse(Console.ReadLine());
            int[] mapDimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = mapDimentions[0];
            int colums = mapDimentions[1];
            char[,] map = new char[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                char[] currentInput = Console.ReadLine().ToCharArray();

                for (int j = 0; j < colums; j++)
                {
                    map[i, j] = currentInput[j];
                }
            }
            int turns = 0;
            int col = 0;

            for (int row = 0; row < rows; row++)
            {
                if (col == colums)
                {
                    PrintSuccessFullResult(health, turns);
                    return;
                }
                health = CalculateHealth(map, row, col, turns, health);

                if (health <= 0)
                {
                    Console.WriteLine("Died at: [{0}, {1}]", row, col);
                    return;
                }

                turns = CalculateTurns(map, row, col, turns);
                turns++;

                if (row == rows - 1)
                {
                    col++;
                    if (col >= colums)
                    {
                        PrintSuccessFullResult(health, turns);
                        return;
                    }

                    for (int opositeRow = rows - 1; opositeRow >= 0; opositeRow--)
                    {
                        health = CalculateHealth(map, opositeRow, col, turns, health);

                        if (health <= 0)
                        {
                            Console.WriteLine("Died at: [{0}, {1}]", opositeRow, col);
                            return;
                        }

                        turns = CalculateTurns(map, opositeRow, col, turns);
                        turns++;

                        if (opositeRow == 0)
                        {
                            col++;
                            row = -1;
                        }
                    }
                }
            }
            Console.WriteLine();
        }

        private static int CalculateTurns(char[,] map, int row, int col, int turns)
        {
            switch (map[row, col])
            {
                case 'T':
                    turns += 2;
                    break;
                default:
                    break;
            }
            return turns;
        }

        private static long CalculateHealth(char[,] map, int row, int col, int turns, long inputHealth)
        {
            switch (map[row, col])
            {
                case 'F':
                    inputHealth -= turns / 2;
                    break;
                case 'H':
                    inputHealth += turns / 3;
                    break;
                default:
                    break;
            }
            return inputHealth;
        }

        private static void PrintSuccessFullResult(long health, int turns)
        {
            Console.WriteLine("Quest completed!");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Turns: {turns}");
        }
    }
}
