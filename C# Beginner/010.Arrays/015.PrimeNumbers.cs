//Write a program that finds all prime numbers in the range [1 ... N]. Use the Sieve of Eratosthenes
//algorithm. The program should print the biggest prime number which is <= N.

using System;

namespace _015.PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main()
        {
            bool outPut = true;

            int n = int.Parse(Console.ReadLine());
            int count = n;

            for (int i = 2; i < n; i++)
            {
                for (int j = 2; j < n; j++)
                {
                    if (count % j == 0 && count != j)
                    {
                        outPut = false;
                        break;
                    }
                }
                
                if (outPut == true)
                {
                    Console.WriteLine(count);
                    break;
                }
                count -= 1;
                outPut = true;
            }
        }
    }
}
