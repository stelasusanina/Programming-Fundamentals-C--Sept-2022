using System;

namespace _01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());  
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            long sum = (long)a + b;
            long division = sum / c;
            long multiply = division * d;
            Console.WriteLine(multiply);
        }
    }
}
