//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find the maximal sum of K elements in the array.

using System;

namespace _006.MaximalKSum
{
    class MaximalKSum
    {
        static void Main()
        {
            int result = 0;

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);
            Array.Reverse(array);

            for (int i = 0; i < k; i++)
            {
                result += array[i];
            }

            Console.WriteLine(result);
        }
    }
}
