using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator06
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public string Name
        {
            get => name; 
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    Exception ae = new ArgumentException("A name should not be empty.");
                    Console.WriteLine(ae.Message);
                }
                name = value;
            }
        }
        public int Endurance
        {
            get => endurance; 
            set
            {
                if (value < 0 || value > 100 )
                {
                    Exception ae = new ArgumentException($"{value} should be between 0 and 100.");
                    Console.WriteLine(ae.Message);
                }
                endurance = value;
            }
        }
        public int Sprint
        {
            get => sprint; 
            set
            {
                if (value < 0 || value > 100)
                {
                    Exception ae = new ArgumentException($"{value} should be between 0 and 100.");
                    Console.WriteLine(ae.Message);
                }
                sprint = value;
            }
        }
        public int Dribble
        {
            get => dribble; 
            set
            {
                if (value < 0 || value > 100)
                {
                    Exception ae = new ArgumentException($"{value} should be between 0 and 100.");
                    Console.WriteLine(ae.Message);
                }
                dribble = value;
            }
        }
        public int Passing
        {
            get => passing; 
            set
            {
                if (value < 0 || value > 100)
                {
                    Exception ae = new ArgumentException($"{value} should be between 0 and 100.");
                    Console.WriteLine(ae.Message);
                }
                passing = value;
            }
        }
        public int Shooting
        {
            get => shooting; 
            set
            {
                if (value < 0 || value > 100)
                {
                    Exception ae = new ArgumentException($"{value} should be between 0 and 100.");
                    Console.WriteLine(ae.Message);
                }
                shooting = value;
            }
        }

        public int SkillLevel { get => GetSkillLevel(); }

        private int GetSkillLevel()
        {
            return (int)Math.Round((Endurance + Sprint + Dribble + Passing + Shooting) / 5.0);
        }             
                    
    }                
}                    
