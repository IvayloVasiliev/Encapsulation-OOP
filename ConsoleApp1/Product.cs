using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree04
{
    public class Product
    {
        private string name;
        private decimal cost;

        public Product(decimal cost, string name)
        {
            Cost = cost;
            Name = name;
        }

        public decimal Cost
        {
            get { return cost; }
            set
            {
                if (value < 0)
                {
                    Exception ex = new ArgumentException("Name cannot be empty");
                    Console.WriteLine(ex);
                    Environment.Exit(0);
                }

                cost = value;
            }
        }


        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    Exception ex = new ArgumentException("Money cannot be negative");
                    Console.WriteLine(ex);
                    Environment.Exit(0);
                }
                name = value;
            }
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
