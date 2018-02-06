using System;
using System.Numerics;

namespace _009.Tribonacci
{
    class Tribonacci
    {
        static void Main()
        {
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            BigInteger b = BigInteger.Parse(Console.ReadLine());
            BigInteger c = BigInteger.Parse(Console.ReadLine());
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger last = 1;

            for (BigInteger i = 1; i <= n - 3; i++)
            {
                if (i != 1)
                {
                    a = b;
                    b = c;
                    c = last;
                }
                last = a + b + c;
            }
            if (n <= 3)
            {
                Console.WriteLine(c);
            }
            if (n > 3)
            {
                Console.WriteLine(last);
            }
        }
    }
}
