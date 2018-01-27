//Write a program that enters 3 real numbers and prints them sorted in descending order.

using System;

namespace _007.Sort3Numbers
{
    class Sort3Numbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double[] numArray = new double[] { a, b, c };

            Array.Sort(numArray);
            Array.Reverse(numArray);
            
            Console.Write(String.Join(" ", numArray));
        }
    }
}
