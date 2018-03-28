using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034.Flasks
{
    class Flasks
    {
        static void Main()
        {
            BigInteger count = 2;
            BigInteger liters = 2;

            string[] input = Console.ReadLine().Split();

            BigInteger n = Convert.ToUInt64(input[0]);
            BigInteger inputL = Convert.ToUInt64(input[1]);

            for (BigInteger i = 3; i <= n; i++)
            {
                liters = count + liters;

                if (liters >= inputL)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i + 1);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
                count++;
            }
        }
    }
}
