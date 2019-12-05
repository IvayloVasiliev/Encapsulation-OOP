using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator06
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
           
            string[] data = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            while (data[0] != "END")
            {
                string teamName = data[1];

                Team team = new Team(teamName);
                teams.Add(team);
                
                if (data[0] == "Add")
                {
                    bool teamExist = teams.Any(t=> t.Name == teamName);

                    string playerName = data[2];
                    int endurance = int.Parse(data[3]);
                    int sprint = int.Parse(data[4]);
                    int dribble = int.Parse(data[5]);
                    int passing = int.Parse(data[6]);
                    int shooting = int.Parse(data[7]);

                    if (teamExist)
                    {
                        team = teams.Where(t => t.Name == teamName).First();
                        Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                        team.Add(player);
                    }
                    else
                    {
                        Console.WriteLine($"Team {teamName} does not exist.");
                    }

                }
                else if (data[0] == "Remove")
                {
                    string playerName = data[2];

                    var playersNames = team.Players.Select(n => n.Name).ToList();
                    team = teams.Where(t => t.Name == teamName).First();
                    team.Remove(playerName);
                   
                }
                else if (data[0] == "Rating")
                {
                    
                    bool teamExists = teams.Any(t => t.Name == teamName);
                    if (teamExists)
                    {
                        team = teams.Where(t => t.Name == teamName).First();
                        var teamRating = team.GetRating();
                        Console.WriteLine($"{team.Name} - {teamRating}");
                    }
                    else
                    {
                        Exception ae = new ArgumentException($"Team {teamName} does not exist.");
                        Console.WriteLine(ae.Message);
                    }
                }

                data = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            }


        }
    }
}
