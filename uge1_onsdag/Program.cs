using System;
using System.Diagnostics.Metrics;

namespace uge1_onsdag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            do {
                Console.Clear();
                Console.WriteLine("Type '1' for odd numbers between 1 and 20");
                Console.WriteLine("Type '2' to enter the magic land");
                Console.WriteLine("Type '3' to get the theater ticket price");
                Console.WriteLine("Type '4' to choose topping for your pizza");
                Console.WriteLine("Type '5' to exit\n");
                Console.Write("Time to make a choice:");
                try
                {
                    start = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    //throw;
                }

                switch (start)
                {
                    case 1:
                        Console.WriteLine("\n----- Exercise 1 -----");
                        Exercise_1.OddNumber();
                        Console.WriteLine("\nPress a key to return to menu");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("\n----- Exercise 2 -----");
                        Exercise_2 e2 = new Exercise_2();
                        Console.WriteLine(e2.Magic());
                        Console.WriteLine("\nPress a key to return to menu");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("\n----- Exercise 3 -----");
                        Console.Write("Please enter your age: ");
                        int age = int.Parse(Console.ReadLine());
                        Exercise_3 e3 = new Exercise_3();
                        Console.WriteLine(e3.Tickets(age));
                        Console.WriteLine("\nPress a key to return to menu");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("\n----- Exercise 4 -----");
                        Pizza p = new Pizza();
                        Console.WriteLine("\nPress a key to return to menu");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("\nSee you next time");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Acces denied - Only 1 to 5 is acceptede");
                        Console.WriteLine("\nPress a key to return to menu");
                        Console.ReadKey();
                        break;
                }
            }while (start != 5);
            Console.ReadKey();
        }   
    }
}