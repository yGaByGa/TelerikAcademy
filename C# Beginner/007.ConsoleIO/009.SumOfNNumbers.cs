//Write a program that enters a number N and after that enters more N numbers and calculates and prints their sum.

using System;

namespace _009.SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            double result = 0;
            double n = double.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                result += double.Parse(Console.ReadLine());
            }
            Console.WriteLine(result);
        }
    }
}
