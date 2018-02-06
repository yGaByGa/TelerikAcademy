using System;

namespace _012.NotDivisableNumber
{
    class NotDivisableNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write(i);
                }
            }

        }
    }
}
