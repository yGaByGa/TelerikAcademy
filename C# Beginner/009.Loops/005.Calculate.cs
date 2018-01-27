//Write a program that, for a given two numbers N and x, 
//calculates the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.
//Use only one loop.Print the result with 5 digits after the decimal point.


using System;

namespace _005.Calculate
{
    class Calculate
    {
        static void Main()
        {
            decimal factorielN = 1;
            decimal result = 0;
            
            double n = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                result += (factorielN *= i) / (decimal)Math.Pow(x, i);
            }

            Console.WriteLine("{0:f5}", (1 + result));
        }
    }
}
