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
            var leagueStandings = new Dictionary<string, long>();
            var topLeague = new Dictionary<string, long>();
            string input = "";

            while ((input = Console.ReadLine()) != "final")
            {
                string[] array = input.Split(' ');
                string firstTeam = FindTeam(array[0], key);
                string secondTeam = FindTeam(array[1], key);
                string[] scores = array[2].Split(':');
                long firstTeamScore = long.Parse(scores[0]);
                long secondTeamScore = long.Parse(scores[1]);
                AddToTopLeague(topLeague, firstTeam, firstTeamScore);
                AddToTopLeague(topLeague, secondTeam, secondTeamScore);
                AddToLeagueStandings(leagueStandings, firstTeam, secondTeam, firstTeamScore, secondTeamScore);
            }
            int count = 1;
            Console.WriteLine("League standings:");
            foreach (var team in leagueStandings.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{count}. {team.Key} {team.Value}");
                count++;
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in topLeague.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(3))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");
            }
        }

        private static void AddToLeagueStandings(Dictionary<string, long> leagueStandings, string firstTeam, string secondTeam, long firstTeamScore, long secondTeamScore)
        {
            if (!leagueStandings.ContainsKey(firstTeam))
            {
                if (firstTeamScore > secondTeamScore)
                {
                    leagueStandings.Add(firstTeam, 3);
                }
                else if (firstTeamScore == secondTeamScore)
                {
                    leagueStandings.Add(firstTeam, 1);
                }
                else
                {
                    leagueStandings.Add(firstTeam, 0);
                }
            }
            else
            {
                if (firstTeamScore > secondTeamScore)
                {
                    leagueStandings[firstTeam] += 3;
                }
                else if (firstTeamScore == secondTeamScore)
                {
                    leagueStandings[firstTeam] += 1;
                }
            }
            if (!leagueStandings.ContainsKey(secondTeam))
            {
                if (firstTeamScore < secondTeamScore)
                {
                    leagueStandings.Add(secondTeam, 3);
                }
                else if (firstTeamScore == secondTeamScore)
                {
                    leagueStandings.Add(secondTeam, 1);
                }
                else
                {
                    leagueStandings.Add(secondTeam, 0);
                }
            }
            else
            {
                if (firstTeamScore < secondTeamScore)
                {
                    leagueStandings[secondTeam] += 3;
                }
                else if (firstTeamScore == secondTeamScore)
                {
                    leagueStandings[secondTeam] += 1;
                }
            }
        }

        private static void AddToTopLeague(Dictionary<string, long> topLeague, string team, long score)
        {
            if (!topLeague.ContainsKey(team))
            {
                topLeague.Add(team, score);
            }
            else
            {
                topLeague[team] += score;
            }
        }

        private static string FindTeam(string team, string key)
        {
            int start = team.IndexOf(key) + key.Length;
            int end = team.LastIndexOf(key);
            int length = end - start;
            var newTeam = team.Substring(start, length).ToUpper().Reverse().ToArray();
            return new string(newTeam);
        }
    }
}
