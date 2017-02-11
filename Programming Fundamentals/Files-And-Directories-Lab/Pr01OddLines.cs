using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pr101OddLines
{
    class Pr101OddLines
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("input.txt");

            for (int i = 1; i < text.Length; i+=2)
            {
                File.AppendAllText("output.txt", text[i] + Environment.NewLine);
            }
        }
    }
}
