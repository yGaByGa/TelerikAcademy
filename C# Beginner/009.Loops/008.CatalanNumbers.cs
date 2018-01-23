//Write a program to calculate the Nth Catalan number by given N


using System;
using System.Numerics;

namespace _008.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            //input
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger catalanN = 1;

            if (n > 0)
            {
                //calculate catalan number
                // C = (2 (2*n + 1) * Cn) / n + 2
                for (BigInteger i = 0; i < n; i++)
                {
                    catalanN = (2 * (2 * i + 1) * catalanN) / (i + 2);
                }
            }
            //output
            Console.WriteLine(catalanN);
        }
    }
}
