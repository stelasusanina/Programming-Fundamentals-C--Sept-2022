using System;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length-1; i >= 0; i--)
            {
                char currentChar = username[i];
                
                password+=currentChar;
            }

            string attemptForPassword =Console.ReadLine();
            int countOfAttempts = 1; 
            while(attemptForPassword!= password)
            {
                if (attemptForPassword != password && countOfAttempts<4)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                if (countOfAttempts == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                countOfAttempts++;

                attemptForPassword = Console.ReadLine();
            }

            if (attemptForPassword == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
