//Write a program that calculates N! / K! for given N and K.
// *Hint: overflow is possible!!

using System;
using System.Numerics;

namespace _006.CalculateAgain
{
    class CalculateAgain
    {
        static void Main()
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            BigInteger K = BigInteger.Parse(Console.ReadLine());

            BigInteger facN = 1;
            BigInteger facK = 1;

            for (BigInteger i = 1; i <= N ; i++)
            {
                facN *= i ;
                if (i <= K)
                {
                    facK *= i ;
                }
            }
            Console.WriteLine(facN / facK);
        }
    }
}
