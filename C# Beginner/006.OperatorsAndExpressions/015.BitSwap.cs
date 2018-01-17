//Write a program first reads 4 numbers n, p, q and k and than swaps bits {p, p+1, …, p+k-1} with bits 
//{q, q+1, …, q+k-1} of n. Print the resulting integer on the console.

using System;

namespace _015.BitSwap
{
    class BitSwap
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            for (int firstIndices = p, secondIndices = q, length = k;
                (firstIndices < 32 && secondIndices < 32) && length > 0;
                firstIndices++, secondIndices++, length--)
            {
                if (((n >> firstIndices) & 1) != ((n >> secondIndices) & 1))
                {
                    n = changeBits(n, firstIndices, secondIndices);
                }
            }
            Console.WriteLine(n);
        }

        private static int changeBits(int number, int firstposition, int secondPosition)
        {
            number ^= (1 << firstposition);
            return number ^ (1 << secondPosition);
        }
    }
}
