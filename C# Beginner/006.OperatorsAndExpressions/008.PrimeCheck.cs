//Write a program that reads an integer N (which will always be less than 100 or equal) and uses an 
//expression to check if given N is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive

using System;

namespace _008.PrimeCheck
{
    class PrimeCheck
    {
        static void Main()
        {
            int n;
            string outPut = "true";

            n = int.Parse(Console.ReadLine());

            if (n < 0 || n == 0 || n == 1)
            {
                outPut = "false";
            }
            
            for (int i = 2; i <= n; i++)
            {
                if (n != i && n != 1)
                {
                    if (n % i == 0)
                    {
                        outPut = "false";
                    }
                }
            }
            Console.WriteLine(outPut);
        }
    }
}
