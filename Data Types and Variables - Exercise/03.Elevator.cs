using System;

namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());
            int courses = 0;
            int additional = 0;
            if (countOfPeople%capacityOfElevator == 0)
            {
                courses = countOfPeople/capacityOfElevator;
                Console.WriteLine(courses);
            }
            else 
            {
                courses = countOfPeople / capacityOfElevator;
                additional = countOfPeople%capacityOfElevator;
                if (additional < capacityOfElevator)
                {
                    courses += 1;
                }
                else
                {
                    courses += additional % capacityOfElevator;
                }
                
                Console.WriteLine(courses);
            }
        }
    }
}
