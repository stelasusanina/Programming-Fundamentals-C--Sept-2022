using System;

namespace _05.PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startCh = int.Parse(Console.ReadLine());
            int endCh = int.Parse(Console.ReadLine());

            for (int i = startCh; i <= endCh; i++)
            {
                char ch = (char)i;
                Console.Write($"{ch} ");
            }
        }
    }
}
