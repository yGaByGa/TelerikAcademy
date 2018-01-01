//Write a program that safely compares two floating-point numbers (double) with precision eps = 0.000001.

using System;
using System.Collections.Generic;

namespace _013.ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            double a = 0;
            double b = 0;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            double result = Math.Abs(a - b);

            if (result < 0.000001)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
