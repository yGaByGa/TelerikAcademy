//Write a program that finds the index of given element X in a sorted array of N integers 
//by using the Binary search algorithm.

using System;

namespace _011.BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            bool noPrint = true;

            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (array[i] == x)
                {
                    Console.WriteLine(i);
                    noPrint = false;
                    break;
                }
            }
            if (noPrint == true)
            {
                Console.WriteLine(-1);
            }
        }
    }
}
