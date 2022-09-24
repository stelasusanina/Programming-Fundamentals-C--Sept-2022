using System;

namespace _09.SumofOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int numbers = 1;
            int sum = 0;
            while (count > 0)
            {
                Console.WriteLine(numbers);
                
                sum += numbers;
                numbers += 2;
                count--;
            }
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
