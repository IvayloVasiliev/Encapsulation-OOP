using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator06
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            Name = name;
            Players = new List<Player>();
        }

        public string Name { get => name; set => name = value; }
        
        public List<Player> Players { get => players; set => players = value; }

        public void Add(Player player)
        {
            Players.Add(player);
        }
        public void Remove(string playerName)
        {
            bool containsPlayer = Players.Any(p => p.Name == playerName);
            if (!containsPlayer)
            {
                Exception ae = new ArgumentException($"Player {playerName} is not in {Name} team.");
                Console.WriteLine(ae.Message);
            }
            Player player = this.players.Where(p => p.Name == playerName).First();
            this.players.Remove(player);

        }

        public int GetRating()
        {
            if (Players.Count == 0)
            {
                return 0;
            }
            return (int)Math.Round(Players.Select(p => p.SkillLevel).Sum() / (double)Players.Count);
        }

    }
}
