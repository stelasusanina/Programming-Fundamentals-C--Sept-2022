using System;

namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfLostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetTrash = 0;
            int mouseTrash = 0;
            int keyboardTrash = 0;
            int displayTrash = 0;

            for (int i = 1; i <= countOfLostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsetTrash++;
                }
                if (i % 3 == 0)
                {
                    mouseTrash++;
                }

                if (i % 6 == 0)
                {
                    keyboardTrash++;
                    if (keyboardTrash % 2 == 0)
                    {
                        displayTrash++;
                    }
                }

            }

            double costs = headsetPrice*headsetTrash + mousePrice*mouseTrash + keyboardPrice*keyboardTrash
                + displayPrice*displayTrash;

            Console.WriteLine($"Rage expenses: {costs:f2} lv.");
        }
    }
}
