using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr03FootballLeague
{
    class Pr03FootballLeague
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            string input = "";
            var leagueStandings = new Dictionary<string, int>();
            var teamGoals = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "final")
            {
                string[] info = input.Split(' ');
                string firstTeamName = GetTeam(info[0], key);
                string secondTeamName = GetTeam(info[1], key);

                string[] score = info[2].Split(':');
                int firstTeamScores = int.Parse(score[0]);
                int secondTeamScores = int.Parse(score[1]);

                if (!leagueStandings.ContainsKey(firstTeamName))
                {
                    if (firstTeamScores > secondTeamScores)
                    {
                        leagueStandings.Add(firstTeamName, 3);
                    }
                    else if (firstTeamScores == secondTeamScores)
                    {
                        leagueStandings.Add(firstTeamName, 1);
                    }
                    else
                    {
                        leagueStandings.Add(firstTeamName, 0);
                    }
                }
                else
                {
                    if (firstTeamScores > secondTeamScores)
                    {
                        leagueStandings[firstTeamName] += 3;
                    }
                    else if (firstTeamScores == secondTeamScores)
                    {
                        leagueStandings[firstTeamName] += 1;
                    }
                }
                if (!leagueStandings.ContainsKey(secondTeamName))
                {
                    if (firstTeamScores < secondTeamScores)
                    {
                        leagueStandings.Add(secondTeamName, 3);
                    }
                    else if (firstTeamScores == secondTeamScores)
                    {
                        leagueStandings.Add(secondTeamName, 1);
                    }
                    else
                    {
                        leagueStandings.Add(secondTeamName, 0);
                    }
                }
                else
                {
                    if (firstTeamScores < secondTeamScores)
                    {
                        leagueStandings[secondTeamName] += 3;
                    }
                    else if (firstTeamScores == secondTeamScores)
                    {
                        leagueStandings[secondTeamName] += 1;
                    }
                }
                if (!teamGoals.ContainsKey(firstTeamName))
                {
                    teamGoals.Add(firstTeamName, 0);
                }
                teamGoals[firstTeamName] += firstTeamScores;
                if (!teamGoals.ContainsKey(secondTeamName))
                {
                    teamGoals.Add(secondTeamName, 0);
                }
                teamGoals[secondTeamName] += secondTeamScores;
            }

            Console.WriteLine("League standings:");
            int count = 1;
            foreach (var team in leagueStandings.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{count}. {team.Key} {team.Value}");
                count++;
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in teamGoals.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(3))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");
            }
        }
        private static string GetTeam(string teamName, string key)
        {
            int firstIndex = teamName.IndexOf(key) + key.Length;
            int lastIndex = teamName.LastIndexOf(key);
            int length = lastIndex - firstIndex;
            string name = teamName.Substring(firstIndex, length);
            return string.Join("", name.ToUpper().Reverse());
        }
    }
}
