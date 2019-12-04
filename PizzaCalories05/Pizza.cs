using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories05
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
            Toppings = new List<Topping>();
        }

        public string Name
        {
            get => name; 
            set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    Exception ex = new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                name = value;
            }
        }

        internal Dough Dough { get => dough; set => dough = value; }

        internal List<Topping> Toppings
        {
            get => toppings; 
            set
            {
                if (value.Count > 10)
                {
                    Exception ex = new ArgumentException("Number of toppings should be in range [0..10].");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
                toppings = value;
            }
        }
        public void Add(Topping topping)
        {
            Toppings.Add(topping);
        }

        private double GetCalories()
        {
            double doughCalories = this.Dough.DoughCalories;
            double toppingCalories = this.Toppings.Sum(c => c.ToppingCalories);
            return toppingCalories + doughCalories;
        }

        public override string ToString()
        {
            return $"{Name} - {GetCalories():f2} Calories.";
        }

    }
}
