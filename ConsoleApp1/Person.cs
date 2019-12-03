using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree04
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            Products = new List<Product>();

        }


        public decimal Money
        {
            get { return money; }
            set 
            {
                if (value < 0)
                {
                    Exception ex = new ArgumentException("Money cannot be negative");
                    Console.WriteLine(ex);
                    Environment.Exit(0);
                }

                money = value;
            }
        }

       
        public string Name
        {
            get { return name; }
            set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    Exception ex = new ArgumentException("Name cannot be empty");
                    Console.WriteLine(ex);
                    Environment.Exit(0);
                }
                name = value;
            }
        }

        internal List<Product> Products { get => products; set => products = value; }

        public void Add(Product product)
        {
            decimal cost = product.Cost;
            string productName = product.Name;

            if (cost > money)
            {
                Console.WriteLine($"{Name} can't afford {productName}");
            }
            else
            {
                Products.Add(product);
                Money -= cost;
                Console.WriteLine($"{Name} bought {productName}");
            }
        }

        public override string ToString()
        {
            if (products.Count == 0)
            {
                return $"{Name} - Nothing bought";
            }
            else
            {
                return $"{Name} - {string.Join(", ", products.Select(x => x.ToString()))}";
            }
        }


    }
}
