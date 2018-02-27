using System;

namespace _015.APlusB
{
    class APlusB
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                int a = int.Parse(tokens[0]);
                int b = int.Parse(tokens[1]);

                Console.WriteLine(a + b);


                //var arr = Console.ReadLine()
                //.Split(' ')
                //.Select(int.Parse)
                //.ToArray();
                //Console.WriteLine(arr[0] + arr[1]);
            }
        }
    }
}
