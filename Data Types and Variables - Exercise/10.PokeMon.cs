using System;

namespace _10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int pokes = 0;
            double originalValue = n * 0.5;

            while (n>=m)
            {
                n-=m;
                pokes++;    

                if (n == originalValue)
                {
                    if (y > 0)
                    {
                        n = n / y;

                        if (n < m)
                        {
                            break;
                        }
                    }
                  
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(pokes);
        }
    }
}
