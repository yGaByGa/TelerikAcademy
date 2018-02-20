//Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.

using System;

namespace _008.MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            int maxSumSoFar = 0;

            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n ; i++)
            {
                int sum = 0;
                for (int j = i; j < n; j++)
                {
                    sum += array[j];
                    if (sum > maxSumSoFar)
                    {
                        maxSumSoFar = sum;
                    }
                }
            }
            Console.WriteLine(maxSumSoFar);
        }
    }
}
