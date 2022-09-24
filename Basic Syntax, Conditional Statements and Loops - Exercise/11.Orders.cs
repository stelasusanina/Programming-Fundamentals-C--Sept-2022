using System;

namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());

            double totalCost = 0;

            for (int i = 1; i <= countOfOrders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int countOfCapsules = int.Parse(Console.ReadLine());

                double totalForOrder = (days * countOfCapsules * pricePerCapsule);
                Console.WriteLine($"The price for the coffee is: ${totalForOrder:f2}");

                totalCost += totalForOrder;
            }

            Console.WriteLine($"Total: ${totalCost:f2}");
        }
    }
}
