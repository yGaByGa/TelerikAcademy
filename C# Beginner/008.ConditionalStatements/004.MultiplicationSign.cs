//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.

using System;

namespace _004.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double result = a * b * c;

            if (result == 0)
            {
                Console.WriteLine(0);
            }
            else if (result > 0)
            {
                Console.WriteLine("+");
            }
            else if (result < 0)
            {
                Console.WriteLine("-");
            }
        }
    }
}
