using System;

namespace _06.TriplesofLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfLetters = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfLetters; i++)
            {
                char first = (char)(i+97);

                for (int j = 0; j < countOfLetters; j++)
                {
                    char second = (char)(j+97);

                    for (int k = 0; k < countOfLetters; k++)
                    {
                        char third = (char)(k+97);
                        Console.Write($"{first}{second}{third}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
