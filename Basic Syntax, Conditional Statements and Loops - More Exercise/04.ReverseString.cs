﻿using System;

namespace _04.ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reversedString = string.Empty;
            for (int i = input.Length-1; i >=0 ; i--)
            {
               reversedString += input[i];
               
            }
            Console.WriteLine(reversedString);
        }
    }
}
