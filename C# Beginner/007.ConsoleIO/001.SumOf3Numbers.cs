//Write a program that reads 3 real numbers from the console and prints their sum.

using System;

namespace _001.SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}", (a+b+c));
        }
    }
}
