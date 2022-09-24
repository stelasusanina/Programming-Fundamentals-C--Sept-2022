using System;

namespace _06.Strongnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            int numCopy = inputNumber;
            int factorialSum = 0;
            while(numCopy > 0)
            {
                int lastDigit = numCopy % 10;
                numCopy /= 10;

                int factorial = 1;

                for (int i = 1; i <= lastDigit; i++)
                {
                    factorial *= i;
                }

                factorialSum+=factorial;
            }

            if (inputNumber == factorialSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
