using System;

namespace _11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());
            int snowballValue = 0;
            System.Numerics.BigInteger maxValue = 0;

            int maxsnowballSnow = 0;
            int maxsnowballTime = 0;
            int maxsnowballQuality = 0;

            for (int i = 1; i <= numberOfSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                snowballValue = (snowballSnow / snowballTime);
                snowballValue = (int)Math.Pow(snowballValue, snowballQuality);

                if (snowballValue > maxValue)
                {
                    maxsnowballSnow = snowballSnow;
                    maxsnowballTime = snowballTime;
                    maxsnowballQuality = snowballQuality;
                    maxValue = snowballValue;
                }
            }

            Console.WriteLine($"{maxsnowballSnow} : {maxsnowballTime} = {maxValue} ({maxsnowballQuality})");
        }
    }
}
