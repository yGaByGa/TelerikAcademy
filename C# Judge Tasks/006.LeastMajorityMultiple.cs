using System;

namespace _006.LeastMajorityMultiple
{
    class LeastMajorityMultiple
    {
        static void Main()
        {
            int count = 0;

            ulong a = ulong.Parse(Console.ReadLine());
            ulong b = ulong.Parse(Console.ReadLine());
            ulong c = ulong.Parse(Console.ReadLine());
            ulong d = ulong.Parse(Console.ReadLine());
            ulong e = ulong.Parse(Console.ReadLine());

            for (ulong i = 2; i < 100000000; i++)
            {
                if (i % a == 0)
                {
                    count++;
                }
                if (i % b == 0)
                {
                    count++;
                }
                if (i % c == 0)
                {
                    count++;
                }
                if (i % d == 0)
                {
                    count++;
                }
                if (i % e == 0)
                {
                    count++;
                }
                if (count >= 3)
                {
                    Console.WriteLine(i);
                    break;
                }
                count = 0;
            }
        }
    }
}
