//We are given an integer number N (read from the console), a bit value v (read from the console as well) (v = 0 or 1) and a 
//position P (read from the console). Write a sequence of operators (a few lines of C# code) that modifies N to hold the value v
//at the position P from the binary representation of N while preserving all other bits in N. Print the resulting number on the 
//console.

using System;

namespace _013.ModifyBit
{
    class ModifyBit
    {
        static void Main()
        {
            ulong n = ulong.Parse(Console.ReadLine());
            byte p = byte.Parse(Console.ReadLine());
            byte v = byte.Parse(Console.ReadLine());

            ulong result;
            ulong mask;

            if (p >= 0 && p < 64)
            {
                if (v == 1)
                {
                    mask = (ulong)1 << p;
                    result = mask | n;
                    Console.WriteLine(result);
                }
                else if (v == 0)
                {
                    mask = (ulong)~(1 << p);
                    result = mask & n;
                    Console.WriteLine(result);
                }
            }
        }
    }
}