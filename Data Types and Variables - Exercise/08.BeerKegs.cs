using System;

namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int groups = int.Parse(Console.ReadLine());
           int count = groups * 3;
           double maxValue = double.MinValue;
           string biggestVolume = "";
            for (int i = 0; i < groups; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double volume = Math.Round(Math.PI) * ((int)radius*radius) * height;
                
                if (volume > maxValue)
                {
                    maxValue = volume;
                    biggestVolume = model;
                }
            }
            Console.WriteLine(biggestVolume);
        }
    }
}
