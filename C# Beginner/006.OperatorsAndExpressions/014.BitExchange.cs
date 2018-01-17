//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer(read from the console).

using System;

namespace _014.BitExchange
{
    class BitExchange
    {
        static void Main()
        {
            uint input = uint.Parse(Console.ReadLine());

            uint mask1 = (1U << 3) | (1U << 4) | (1U << 5);
            uint mask2 = (1U << 24) | (1U << 25) | (1U << 26);

            uint modifiedInput = input & ~mask1 & ~mask2;

            mask1 &= input;
            mask1 <<= 21;
            mask2 &= input;
            mask2 >>= 21;
            modifiedInput |= mask1 | mask2;

            Console.WriteLine(modifiedInput);

        }
    }
}
