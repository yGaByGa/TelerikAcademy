//Write a program that gets two numbers from the console and prints the greater of them.

using System;

namespace _005.NumberComparer
{
    class NumberComparer
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}" , Math.Max(a , b));
        }
    }
}
