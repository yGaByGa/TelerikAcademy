using System;

namespace _003.ForestRoad
{
    class ForestRoad
    {
        static void Main()
        {
            int count = 0;
            int reroll = 0;
            
            int n = int.Parse(Console.ReadLine());

            char[] road = new char[n];

            reroll = n - 2;

            for (int i = 0 ; i <= (2 * n) - 2 ; i++)
            {
                count++;
                for (int y = 0 ; y < n ; y++)
                {
                    road[y] = '.';
                }

                if (i <= n - 1)
                {
                    road[i] = '*';
                }
                else if (i >= n - 1)
                {
                    road[reroll--] = '*';
                }

                foreach (var x in road)
                {
                    Console.Write(x);
                }
                Console.WriteLine();
            }
        }
    }
}
