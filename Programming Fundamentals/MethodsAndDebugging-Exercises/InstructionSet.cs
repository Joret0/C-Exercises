using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr16InstructionSet
{
    class InstructionSet
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] array = input.Split(' ');
                string command = array[0];
                long result = 0;
                switch (command)
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(array[1]);
                            result = operandOne + 1;
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(array[1]);
                            result = operandOne - 1;
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(array[1]);
                            long operandTwo = long.Parse(array[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(array[1]);
                            long operandTwo = long.Parse(array[2]);
                            result = operandOne * operandTwo;
                            break;
                        }
                }
                Console.WriteLine(result);
                input = Console.ReadLine();
            }
        }
    }
}
