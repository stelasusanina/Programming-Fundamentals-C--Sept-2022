using System;

namespace _08.TownInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfCity = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {nameOfCity} has population of {population} and area {area} square km.");

        }
    }
}
