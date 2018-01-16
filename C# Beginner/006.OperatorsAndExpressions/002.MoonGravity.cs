//Write a program that calculates the weight of a man on the moon by a given weight W(as a floating-point number) on the Earth.

using System;

namespace _002.MoonGravity
{
    class MoonGravity
    {
        static void Main()
        {
            double w = double.Parse(Console.ReadLine());

            double result = w * 0.170  ;

            Console.WriteLine("{0:F3}", result);
            //Math.Round(result, 3)
        }
    }
}
