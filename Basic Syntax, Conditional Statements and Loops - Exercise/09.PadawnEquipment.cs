using System;

namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double johnsBudget = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double tenPercentForLightsaber = Math.Ceiling(countOfStudents + (countOfStudents * 0.1));

            int freeBelts = 0;

            for (int i = 1; i <= countOfStudents; i++)
            {
                if (i % 6 == 0)
                {
                    freeBelts++;
                }
            }

            double all = (priceOfLightsaber * tenPercentForLightsaber) + (countOfStudents*priceOfRobes)+
                (priceOfBelts*(countOfStudents-freeBelts));

            if (all<= johnsBudget)
            {
                Console.WriteLine($"The money is enough - it would cost {all:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(all-johnsBudget):f2}lv more.");
            }
        }
    }
}
