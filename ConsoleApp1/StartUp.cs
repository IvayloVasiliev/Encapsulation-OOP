﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree04
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] inputPeople = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            string[] inputProduct = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < inputPeople.Length; i++)
            {
                string[] tokens = inputPeople[i].Split("=");
                string name = tokens[0];
                decimal money = decimal.Parse(tokens[1]);

                Person person = new Person(name, money);
                people.Add(person);
            }

            for (int i = 0; i < inputProduct.Length; i++)
            {
                string[] tokens = inputProduct[i].Split("=");
                string name = tokens[0];
                decimal cost = decimal.Parse(tokens[1]);

                Product product = new Product(cost, name);
                products.Add(product);
            }

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string person = tokens[0];
                string productName = tokens[1];

                Product product = products.First(p => p.Name == productName);

                people.First(p => p.Name == person).Add(product);

                input = Console.ReadLine();
            }

            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }

        }
    }
}
