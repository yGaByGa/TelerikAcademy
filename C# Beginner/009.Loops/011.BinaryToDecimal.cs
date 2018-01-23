//Using loops write a program that converts a binary integer number to its decimal form.

using System;

namespace _011.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int output = Convert.ToInt32(input, 2);
            Console.WriteLine(output);
        }
    }
}
