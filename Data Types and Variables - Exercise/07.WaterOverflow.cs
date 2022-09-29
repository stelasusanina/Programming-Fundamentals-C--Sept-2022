using System;

namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int litersInTank = 0;

            for (int i = 1; i <= n; i++)
            {
                int quantity = int.Parse(Console.ReadLine());
                if (litersInTank+quantity > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    litersInTank += quantity;
                }

            }

            Console.WriteLine(litersInTank);
        }
    }
}
