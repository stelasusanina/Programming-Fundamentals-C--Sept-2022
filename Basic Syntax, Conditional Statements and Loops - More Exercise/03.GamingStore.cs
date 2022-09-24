using System;

namespace _03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            double price = 0;
            double totalSpent = 0;
            bool outOfMoney = false;

            string input = Console.ReadLine();
            while(input != "Game Time")
            {
                if (input == "OutFall 4")
                {
                    price = 39.99;
                }
                else if (input == "CS: OG")
                {
                    price = 15.99;
                }
                else if (input == "Zplinter Zell")
                {
                    price = 19.99;
                }
                else if (input == "Honored 2")
                {
                    price = 59.99;
                }
                else if (input == "RoverWatch")
                {
                    price = 29.99;
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    price = 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

                if (price > budget)
                {
                    Console.WriteLine("Too Expensive");
                }

                if (input == "OutFall 4" || input == "CS: OG" || input == "Zplinter Zell"
                    || input == "Honored 2" || input == "RoverWatch" || input == "RoverWatch Origins Edition")
                {
                    if (budget >= price)
                    {
                        Console.WriteLine($"Bought {input}");
                        budget -= price;
                        totalSpent += price;
                    }

                }


                if (budget <= 0)
                {
                    Console.WriteLine("Out of money!");
                    outOfMoney = true;
                    break;
                }


                input = Console.ReadLine();
            }
            if (!outOfMoney)
            {
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${budget:f2}");
            }
          
           
        }
    }
}
