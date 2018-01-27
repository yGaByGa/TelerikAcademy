//Write a program that reads two double values from the console A and B, 
//stores them in variables and exchanges their values if the first one is greater than the second one.

using System;

namespace _001.ExchangeNumbers
{
    class ExchangeNumbers
    {
        static void Main()
        {
            double nOne = double.Parse(Console.ReadLine());
            double nTwo = double.Parse(Console.ReadLine());

            if (nOne >= nTwo)
            {
                Console.WriteLine("{0} {1}", nTwo, nOne);
            }
            else if (nTwo >= nOne)
            {
                Console.WriteLine("{0} {1}", nOne, nTwo);
            }
        }
    }
}
