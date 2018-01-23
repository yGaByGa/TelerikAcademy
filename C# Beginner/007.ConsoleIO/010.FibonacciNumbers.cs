//Write a program that reads a number N and prints on the console the first N members of the Fibonacci sequence 
//(at a single line, separated by comma and space - ", ") : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;

namespace _010.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            ulong a = 0;
            ulong b = 0;
            ulong x = 0;

            ulong n = ulong.Parse(Console.ReadLine());

            for (ulong i = 1; i <= n; i++)
            {
                if (i == 2)
                {
                    b++;
                }

                a = b;
                b = x;
                x = a + b;
                if (i == n)
                {
                    Console.Write("{0}", x);
                }
                else if (i < n)
                {
                    Console.Write("{0}, ", x);
                }
            }
        }
    }
}
