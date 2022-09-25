using System;

namespace _03.ExactSumofRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            decimal input = 0;
            decimal sum=0;
            for (int i = 1; i <= count; i++)
            {
                input =decimal.Parse(Console.ReadLine());
                sum+=input;
            }
            Console.WriteLine(sum);
        }
    }
}
