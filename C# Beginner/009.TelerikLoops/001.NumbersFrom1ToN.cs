using System;

namespace _001.NumbersFrom1ToN
{
    class ProgrNumbersFrom1ToNam
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i == n)
                {
                    Console.WriteLine(i);
                    break;
                }
                Console.Write("{0} ", i);
            }
        }
    }
}
