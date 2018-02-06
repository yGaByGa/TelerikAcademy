using System;
using System.Numerics;

namespace _016.Trailing0InFactorial
{
    class Trailing0InFactorial
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger fac = 1;
            int x = 1;
            int count0 = 0;

            //calculate factorial 
            do
            {
                fac *= x;
                x++;
            } while (x <= n);

            //split and count the nulls
            int lengthh = fac.ToString().Length;
            BigInteger[] array = new BigInteger[lengthh];

            for (int i = 0; i < lengthh; i++)
            {
                array[i] = fac % 10;
                fac /= 10;
            }

            for (int i = 0; i < array.LongLength; i++)
            {
                if (array[i] == 0)
                {
                    count0++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count0);
        }
    }
}
