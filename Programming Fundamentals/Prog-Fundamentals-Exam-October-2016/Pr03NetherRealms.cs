using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pr03NetherRealms
{
    class Pr03NetherRealms
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(n => n.Trim()).ToArray();
            SortedDictionary<string, Dictionary<long, double>> demons = new SortedDictionary<string, Dictionary<long, double>>();

            Regex letters = new Regex(@"([^\d\+\-\*\/\.])");
            Regex digits = new Regex(@"(-*\d+\.*\d*)");

            for (int i = 0; i < input.Length; i++)
            {
                string name = input[i];
                var matchLetters = letters.Matches(name);
                var matchDigits = digits.Matches(name);

                long health = 0;
                foreach (Match item in matchLetters)
                {
                    health += char.Parse(item.Value);
                }

                double damage = 0;
                foreach (Match item in matchDigits)
                {
                    damage += double.Parse(item.Value);
                }

                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j] == '*')
                    {
                        damage *= 2;
                    }
                    else if (name[j] == '/')
                    {
                        damage /= 2;
                    }
                }
                Dictionary<long, double> stats = new Dictionary<long, double>();
                stats.Add(health, damage);
                demons.Add(name, stats);
            }
            foreach (var name in demons)
            {
                foreach (var stats in demons[name.Key])
                {
                    Console.WriteLine($"{name.Key} - {stats.Key} health, {stats.Value:f2} damage");
                }
            }
        }
    }
}
