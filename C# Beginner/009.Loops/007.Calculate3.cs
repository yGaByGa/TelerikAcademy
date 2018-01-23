//write a program that calculates N! / (K! * (N - K)!) for given N and K.
//Hint: overflow is possible!!

using System;
using System.Numerics;

namespace _007.Calculate3
{
    class Calculate3
    {
        static void Main()
        {
            //input
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            BigInteger K = BigInteger.Parse(Console.ReadLine());

            BigInteger facN = 1;
            BigInteger facK = 1;
            BigInteger razlika = N - K;
            BigInteger facRazlika = 1;

            for (BigInteger i = 1; i <= N; i++)
            {
                //calculate N!
                facN *= i;

                if (i <= K)
                {
                    //calculate K!
                    facK *= i;
                }

                if ( i <= razlika)
                {
                    //calculate (N - K)!
                    facRazlika *= i;
                }
            }
            //output
            Console.WriteLine( facN / (facK * facRazlika));
        }
    }
}
