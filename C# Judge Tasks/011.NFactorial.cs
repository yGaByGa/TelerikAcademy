using System;
using System.Numerics;

namespace _011.NFactorial
{
    class NFactorial
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger fac = 1;
            int i = 1;

            do
            {
                fac *= i;
                i++;
            } while (i <= n);

            Console.WriteLine(fac);
        }
    }
}
