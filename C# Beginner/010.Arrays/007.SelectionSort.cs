//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the Selection sort
//algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc

using System;

namespace _007.SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);

            foreach (int x in array)
            {
                Console.WriteLine(x);
            }
        }
    }
}
