//Using loops write a program that converts a hexadecimal integer number to its decimal form.

using System;
using System.Collections.Generic;

namespace _014.HexToDecimal
{
    class HexToDecimal
    {
        static Dictionary<char, long> hexdecval = new Dictionary<char, long>
        {
        {'0', 0},
        {'1', 1},
        {'2', 2},
        {'3', 3},
        {'4', 4},
        {'5', 5},
        {'6', 6},
        {'7', 7},
        {'8', 8},
        {'9', 9},
        {'a', 10},
        {'b', 11},
        {'c', 12},
        {'d', 13},
        {'e', 14},
        {'f', 15},
        };

        static decimal HexToDec(string hex)
        {
            long result = 0;
            hex = hex.ToLower();

            for (int i = 0; i < hex.Length; i++)
            {
                char valAt = hex[hex.Length - 1 - i];
                result += hexdecval[valAt] * (long)Math.Pow(16, i);
            }

            return result;
        }

        static void Main()
        {
            string hex = Console.ReadLine().Trim();

            Console.WriteLine("{0}", HexToDec(hex));
        }
    }
}
