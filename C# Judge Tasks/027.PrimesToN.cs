using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027.PrimesToN
{
    class PrimesToN
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool isPrime = false;

            for (int i = 1; i <= n; i++)
            {
                isPrime = true;
                for (int j = 1; j <= n; j++)
                {
                    if (i % j == 0 && i != j && j != 1)
                    {
                        isPrime = false;
                        break;
                    }
                    else
                    {
                        isPrime = true;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
