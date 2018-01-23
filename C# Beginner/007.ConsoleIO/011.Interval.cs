//Write a program that reads two positive integer numbers N and M and prints how many numbers exist between
// them such that the reminder of the division by 5 is 0.

using System;

namespace _011.Interval
{
    class Interval
    {
        static void Main()
        {
            int count = 0;

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            if (n < m)
            {
                for (int i = n + 1 ; i < m; i++)
                {
                    if (i % 5 == 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
            else if (n == m)
            {
                Console.WriteLine(count);
            }
        }
    }
}
