//Write a program that reads a pair of coordinates x and y and uses an expression to checks for 
//given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

namespace _010.PointCircleRectangle
{
    class PointCircleRectangle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5)
            {
                Console.Write("inside circle");
            }
            else
            {
                Console.Write("outside circle");
            }
            if ((x >= -1 && x <= 5) && (y <= 1 && y >= -1))
            {
                Console.Write(" inside rectangle");
            }
            else
            {
                Console.WriteLine(" outside rectangle");
            }
            Console.WriteLine();
        }
    }
}
