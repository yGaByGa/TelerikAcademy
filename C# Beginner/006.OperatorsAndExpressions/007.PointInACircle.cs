//Write a program that reads the coordinates of a point x and y and using an expression checks if given point (x, y) 
//is inside a circle K({0, 0}, 2) - the center has coordinates (0, 0) and the circle has radius 2. The program should 
//then print "yes DISTANCE" if the point is inside the circle or "no DISTANCE" if the point is outside the circle.
//In place of DISTANCE print the distance from the beginning of the coordinate system - (0, 0) - to the given point.

using System;

namespace _007.PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            double x, y, result;
            string yesNo = "#";

            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            result = Math.Sqrt((x * x) + (y * y));

            if (result <= 2)
            {
                yesNo = "yes";
            }
            else
            {
                yesNo = "no";
            }

            Console.WriteLine("{1} {0:F2}" ,result ,yesNo);
        }
    }
}
