//Write a program that sorts an array of integers using the Quick sort algorithm.

using System;

namespace _014.QuickSort
{
    class QuickSort
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] tokens = new int[n];

            for (int i = 0; i < n; i++)
            {
                tokens[i] = int.Parse(Console.ReadLine());
            }
            
            Array.Sort(tokens);

            foreach (var x in tokens)
            {
                Console.WriteLine(x);
            }
        }
    }
}
