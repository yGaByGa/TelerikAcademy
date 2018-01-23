//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

namespace _006.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double xOne = (-b - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
            double xTwo = (-b + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
            
            if (((b * b) - (4 * a * c)) > 0)
            {
                Console.WriteLine("{0:F2}", xOne);
                Console.WriteLine("{0:F2}", xTwo);
            }
            else if (((b * b) - (4 * a * c)) == 0)
            {
                Console.WriteLine("{0:F2}", xOne);
            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
