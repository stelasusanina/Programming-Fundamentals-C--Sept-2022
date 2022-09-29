using System;

namespace _09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int startingYield = int.Parse(Console.ReadLine());
           int sumExtraction = 0;
           int days = 0;
            while (startingYield > 99)
            {
                sumExtraction += (startingYield - 26);

                startingYield -= 10;
                days++;
            }

            if (sumExtraction > 26)
            {
                int lastConsumption = 26;
                sumExtraction -= lastConsumption;
            }

            Console.WriteLine(days);
            Console.WriteLine(sumExtraction);
        }
    }
}
