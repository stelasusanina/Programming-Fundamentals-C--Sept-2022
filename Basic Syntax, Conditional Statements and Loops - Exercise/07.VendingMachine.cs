using System;

namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double allMoneyIn = 0;
            while (input != "Start")
            {
                double moneyIn =double.Parse(input);
                if (moneyIn==0.1 || moneyIn==0.2 || moneyIn==0.5 || moneyIn==1 || moneyIn == 2)
                {
                    allMoneyIn+=moneyIn;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {moneyIn}");
                }


                input = Console.ReadLine();
            }

            
            string product = Console.ReadLine();
            double priceOfProduct = 0;

            while (product != "End")
            {
                if (product == "Nuts")
                {
                    priceOfProduct = 2;
                    product = "nuts";
                }
                else if (product == "Water")
                {
                    priceOfProduct = 0.7;
                    product = "water";
                }
                else if (product == "Crisps")
                {
                    priceOfProduct = 1.5;
                    product = "crisps";
                }
                else if(product == "Soda")
                {
                    priceOfProduct = 0.8;
                    product = "soda";
                }
                else if (product == "Coke")
                {
                    priceOfProduct=1;
                    product = "coke";
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    
                }

                if (allMoneyIn >= priceOfProduct)
                {
                    if (product== "nuts" || product== "water" || product == "crisps" || product == "soda"
                        || product == "coke")
                    {
                        allMoneyIn -= priceOfProduct;
                        Console.WriteLine($"Purchased {product}");
                    }
                  
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
               
                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {allMoneyIn:f2}");
        }
    }
}
