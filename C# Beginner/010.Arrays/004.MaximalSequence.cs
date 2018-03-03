﻿//Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.

using System;

namespace _004.MaximalSequence
{
    class MaximalSequence
    {
        static void Main()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int count = 0;

            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[0] == array[i])
                {
                    count++;
                }
                if (count == array.Length)
                {
                    Console.WriteLine(count);
                    return;
                }
            }

            for (int i = 0; i < n ; i++)
            {
                a = array[i];
                if (i < n - 1)
                {
                    b = array[i + 1];
                }
                if (a == b)
                {
                    c++;
                    if (c > d)
                    {
                        d = c;
                    }
                }
                else
                {
                    c = 0;
                }
            }
            if (d > 1)
            {
                Console.WriteLine(d + 1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
