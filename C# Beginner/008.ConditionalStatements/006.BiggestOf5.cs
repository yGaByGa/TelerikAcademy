﻿//Write a program that finds the biggest of 5 numbers that are read from the console, using only 5 if statements.

using System;

namespace _006.BiggestOf5
{
    class BiggestOf5
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(Math.Max(Math.Max(a, b), c), Math.Max(d, e)));
        }
    }
}
