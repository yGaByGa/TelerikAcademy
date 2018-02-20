//Write a program that reads two integer arrays of size N from the console and compares them element by element.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            int count = 0;

            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];

            for (int i = 0; i < n * 2; i++)
            {
                if (i < n)
                {
                    array1[i] = int.Parse(Console.ReadLine());
                }
                if (i >= n)
                {
                    array2[count] = int.Parse(Console.ReadLine());
                    count++;
                }
            }

            bool bb = array1.Zip(array2, (a, b) => (a == b)).Any(p => !p);
            if (!bb) Console.WriteLine("Equal");
            else Console.WriteLine("Not equal");
        }
    }
}
