//Write a program that sorts an array of integers using the Merge sort algorithm.

using System;

namespace _013.MergeSort
{
    class MergeSort
    {
        static void Main()
        {
            int newIndex2 = 0;
            int newIndex = 0;

            int n = int.Parse(Console.ReadLine());

            int[] tokens = new int[n];

            for (int i = 0; i < n; i++)
            {
                tokens[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (tokens[j] < tokens[i])
                    {
                        newIndex = tokens[i];
                        newIndex2 = tokens[j];
                        tokens[j] = tokens[i];
                        tokens[i] = newIndex2;
                    }
                }
            }

            foreach (var x in tokens)
            {
                Console.WriteLine(x);
            }

            //easy way
            //Array.Sort(tokens);

            //foreach (var x in tokens)
            //{
            //    Console.WriteLine(x);
            //}
        }
    }
}
