using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr02Ladybugs
{
    class Pr02Ladybugs
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] ladybugIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] field = new int[size];
            string input = Console.ReadLine();

            FillField(size, ladybugIndexes, field);

            while (!input.Equals("end"))
            {
                string[] info = input.Split(' ');
                int position = int.Parse(info[0]);
                string direction = info[1];
                int length = int.Parse(info[2]);

                if (position < 0 || position > size - 1 || field[position] != 1)
                {
                    input = Console.ReadLine();
                    continue;
                }

                int newPosition = GetNewPosition(direction, length, position);

                if (newPosition < 0 || newPosition >= size)
                {
                    field[position] = 0;
                    input = Console.ReadLine();
                    continue;
                }
                field[position] = 0;

                while (position < size && position >= 0 && newPosition < size && newPosition >= 0)
                {
                    if (field[newPosition] == 0)
                    {
                        field[newPosition] = 1;
                        break;
                    }
                    else
                    {
                        newPosition = GetNewPosition(direction, length, newPosition);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", field));
        }
        private static int GetNewPosition(string direction, int length, int newPosition)
        {
            if (direction == "right")
            {
                newPosition += length;
            }
            else
            {
                newPosition -= length;
            }

            return newPosition;
        }
        private static void FillField(int size, int[] ladybugIndexes, int[] field)
        {
            for (int i = 0; i < ladybugIndexes.Length; i++)
            {
                if (ladybugIndexes[i] >= 0 && ladybugIndexes[i] < size)
                {
                    field[ladybugIndexes[i]] = 1;
                }
            }
        }
    }
}
