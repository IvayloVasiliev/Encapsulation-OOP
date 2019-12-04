using System;
using System.Collections.Generic;

namespace PizzaCalories05
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] pizzaData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string name = pizzaData[1];

            

            string[] doughData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string flour = doughData[1];
            string bakingTehnique = doughData[2];
            int weight = int.Parse(doughData[3]);

            Dough dough = new Dough(flour, bakingTehnique, weight);
            Pizza pizza = new Pizza(name, dough);
            

            string[] toppingData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (toppingData[0] != "END")
            {
                string toppingType = toppingData[1];
                int toppingWeight = int.Parse(toppingData[2]);

                Topping topping = new Topping(toppingType, toppingWeight);
                pizza.Add(topping);

                toppingData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(pizza);

        }
    }
}
