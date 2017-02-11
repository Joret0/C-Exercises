using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pr02IndexOfLetters
{
    class pr02IndexOfLetters
    {
        static void Main(string[] args)
        {
            char[] input = File.ReadAllText("input.txt").ToCharArray();
            string[] output = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                var result = $"{input[i]} -> {input[i] - 'a'}";
                output[i] = result;
            }

            File.WriteAllLines("output.txt", output);
        }
    }
}
