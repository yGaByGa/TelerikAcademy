//Write a program that reads 5 integer numbers from the console and prints their sum.

using System;

namespace _007.SumOf5Numbers
{
    class SumOf5Numbers
    {
        static void Main()
        {
            int result = 0;
            for (int i = 0; i < 5; i++)
            {
                int n = int.Parse(Console.ReadLine());

                result += n;
            }
            Console.WriteLine(result);
        }
    }
}
