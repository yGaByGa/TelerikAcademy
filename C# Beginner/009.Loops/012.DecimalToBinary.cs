//write a program that converts an integer number to its binary representation.

using System;

namespace _012.DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            string output = Convert.ToString(input, 2);

            Console.WriteLine(output);
        }
    }
}
