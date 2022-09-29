using System;

namespace _04.SumofChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
               char letter = char.Parse(Console.ReadLine());
               sum += (int)letter;
            }

            Console.WriteLine("The sum equals: {0}", sum);
        }
    }
}
