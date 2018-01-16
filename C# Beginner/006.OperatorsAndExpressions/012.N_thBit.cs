//Write a program that reads from the console two integer numbers P and N and prints on the console the value of P's N-th bit.

using System;

namespace _012.N_thBit
{
    class N_thBit
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());

            int mask = 1 << P;
            int test = N & mask;
            int result = test >> P;

            Console.WriteLine(result);
        }
    }
}
