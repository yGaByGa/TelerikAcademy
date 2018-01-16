//Write a program that reads an integer N (which will always be less than 100 or equal) 
//and uses an expression to check if given N is prime (i.e. it is divisible without remainder only to itself and 1).

using System;

namespace _009.Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            double result = 0.000000;
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            result = h * ((a + b) / 2);

            Console.WriteLine("{0:F7}", result);
        }
    }
}
