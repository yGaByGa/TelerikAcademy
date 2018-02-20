using System;

namespace _014.BiggestPrimeNumber
{
    class BiggestPrimeNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            while (true)
            {
                bool isPrime = true;
                int lenght = n / 2;

                for (int i = 2; i < lenght; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(n);
                    return;
                }
                else
                {
                    n -= 1;
                }
            }
        }
    }
}
