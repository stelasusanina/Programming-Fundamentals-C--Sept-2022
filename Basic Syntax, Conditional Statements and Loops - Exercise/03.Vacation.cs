using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0;

            switch (dayOfWeek)
            {
                case "Friday":
                    if (typeOfGroup == "Students")
                    {
                        price = 8.45;
                    }
                    else if (typeOfGroup == "Business")
                    {
                        price = 10.9;
                    }
                    else if (typeOfGroup == "Regular")
                    {
                        price = 15;
                    }
                    break;
                case "Saturday":
                    if (typeOfGroup == "Students")
                    {
                        price = 9.8;
                    }
                    else if (typeOfGroup == "Business")
                    {
                        price = 15.6;
                    }
                    else if (typeOfGroup == "Regular")
                    {
                        price = 20;
                    }
                    break ;
                case "Sunday":
                    if (typeOfGroup == "Students")
                    {
                        price = 10.46;
                    }
                    else if (typeOfGroup == "Business")
                    {
                        price = 16;
                    }
                    else if (typeOfGroup == "Regular")
                    {
                        price = 22.5;
                    }
                    break;
            }

            double total = countOfPeople * price;

            if (typeOfGroup== "Students" && countOfPeople >= 30)
            {
                total = total - (total * 0.15);
            }
            if (typeOfGroup=="Business" && countOfPeople >= 100)
            {
                total = total - (10 * price);
            }
            if (typeOfGroup=="Regular" && countOfPeople>=10 && countOfPeople <= 20)
            {
                total = total - (total * 0.05);
            }

            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}
