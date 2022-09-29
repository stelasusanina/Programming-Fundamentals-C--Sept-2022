using System;

namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int digits = input.ToString().Length;
            int sum = 0;
            for (int i = 1; i <= digits; i++)
            {
                sum += input % 10;
                input /= 10;

            }
            Console.WriteLine(sum);
        }
    }
}
