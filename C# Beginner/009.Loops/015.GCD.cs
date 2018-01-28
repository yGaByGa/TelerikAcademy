//Write a program that calculates the greatest common divisor (GCD) of given two integers A and B.


using System;

namespace _015.GCD
{
    class GCD
    {
        static void Main()
        {
            int firsCD = 0, secondCD = 0, grandCD = 0;

            string[] input = Console.ReadLine().Split();

            //Parse element 0
            int a = int.Parse(input[0]);

            //Parse element 1
            int b = int.Parse(input[1]);

            for (int i = 1; i <= Math.Min(a , b) ; i++)
            {
                if (a % i == 0)
                {
                    firsCD = i;
                }

                if (b % i == 0)
                {
                    secondCD = i;
                }

                if (firsCD == secondCD)
                {
                    grandCD = firsCD;
                }

            }
            Console.WriteLine(grandCD);
        }
    }
}
