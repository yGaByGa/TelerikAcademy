//Write an expression that calculates rectangle’s area and perimeter by given width and height.
//The width and height should be read from the console.

using System;

namespace _004.Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double result1 = width * height;
            double result2 = (width + height) * 2;

            Console.WriteLine("{0:F2} {1:F2}", result1 , result2);
        }
    }
}
