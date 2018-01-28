//Using loops write a program that converts an integer number to its hexadecimal representation.

using System;
using System.Numerics;

public class Exercise55
{
    public static void Main()
    {
        BigInteger decn, q, dn = 0, m, l;
        BigInteger tmp;
        BigInteger s;
        
        decn = Convert.ToInt64(Console.ReadLine());
        q = decn;
        for (l = q; l > 0; l = l / 16)
        {
            tmp = l % 16;
            if (tmp < 10)
                tmp = tmp + 48;
            else
                tmp = tmp + 55;
            dn = dn * 100 + tmp;
        }
        for (m = dn; m > 0; m = m / 100)
        {
            s = m % 100;
            Console.Write("{0}", (char)s);
        }
        Console.WriteLine();
    }
}