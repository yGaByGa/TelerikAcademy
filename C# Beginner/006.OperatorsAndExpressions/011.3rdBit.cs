//Using bitwise operators, write a program that uses an expression to find the value of the bit at index 3 
//of an unsigned integer read from the console.
//The bits are counted from right to left, starting from bit 0.
//The result of the expression should be either 1 or 0. Print it on the console.

using System;

namespace _011._3rdBit
{
    class _3rdBit
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int mask = 1 << 3;
            int test = N & mask;
            int result = test >> 3;

            Console.WriteLine(result);
        }
    }
}
