using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uge1_onsdag
{
    internal class Pizza
    {
        List<string> pizzaTopping = new List<string>();
        string topping = string.Empty;
        int counter = 1;

        public Pizza()
        {
            do
            {
                Console.Write($"Chose {counter}. pizza topping: ");
                topping = Console.ReadLine();

                if (pizzaTopping.Contains(topping))
                {
                    Console.WriteLine($"Your have already added {topping}");
                }
                else if (topping != "stop")
                {
                    pizzaTopping.Add(topping);
                    Console.WriteLine($"You chose {topping}\n");
                    counter++;
                }
            } while (topping != "stop" && counter < 6);

            Console.WriteLine($"Your order has been confirmend with the following {counter-1} toppings:\n ");
            pizzaTopping.ForEach(x => Console.Write($"{x} "));
        }        
    }
}
