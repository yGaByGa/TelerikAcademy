//You are given N longegers(given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal
//to the product of the even elements.
//Elements are counted from 1 to N, so the first element is odd, the second is even, etc.

using System;

namespace _010.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            long p1 = 1, p2 = 1;

            long n = long.Parse(Console.ReadLine());
            while (n < 4 || n > 50)
            {
                n = long.Parse(Console.ReadLine());
            }
            string[] arr = Console.ReadLine().Split(' ');
            long[] a = new long[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(arr[i]);
            }
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    p1 = p1 * a[i];
                }
                else
                {
                    p2 = p2 * a[i];
                }
            }
            if (p1 == p2)
                Console.WriteLine("yes {0}", p1);
            else
            {
                Console.WriteLine("no {0} {1}", p1, p2);
            }
        }
    }
}
