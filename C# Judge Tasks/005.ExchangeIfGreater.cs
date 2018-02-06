using System;

namespace _005.ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Min(a , b) + " " + Math.Max(a , b));
        }
    }
}
