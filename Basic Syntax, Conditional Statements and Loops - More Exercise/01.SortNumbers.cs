﻿using System;

namespace _01.SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a>b && a > c)
            {
                Console.WriteLine(a);
                if (b > c)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                else
                {
                    Console.WriteLine(c);
                    Console.WriteLine(b);
                }
            }

            if (b > a && b>c)
            {
                Console.WriteLine(b);
                if (c > a)
                {
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                }
            }

            if (c > a && c > b)
            {
                Console.WriteLine(c);
                if (b > a)
                {
                    Console.WriteLine(b);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }
            }
        }
    }
}
