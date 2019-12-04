using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories05
{
    public class Topping
    {
        private string type;
        private int weight;

        public Topping(string type, int weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type
        {
            get => type;
            set
            {
                if (value.ToLower() != "meat"
                    && value.ToLower() != "veggies"
                    && value.ToLower() != "cheese"
                    && value.ToLower() != "sauce")
                {
                    throw new InvalidOperationException(String.Format
                       (Exceptions.InvalidToppingTypeException, value));
                }

                type = value;
            }
        }

        public int Weight
        {
            get => weight;
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new InvalidOperationException(String.Format
                        (Exceptions.InvalidToppingWeightException, this.Type));
                }
                weight = value;
            }
        }

        public double ToppingCalories { get => this.CalculateTopingCalories(); }

        private double CalculateTopingCalories()
        {
            double modifier = Type == "meat" ? 1.2 : Type == "veggies" ? 0.8 : Type == "cheese"
                ? 1.1 : 0.9;

            return Weight * 2 * modifier;
        }
    }
}
