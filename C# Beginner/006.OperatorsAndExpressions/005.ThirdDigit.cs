//Write a program that reads an integer N from the console and prints true if the third digit of N is 7,
//or "false THIRD_DIGIT", where you should print the third digits of N.

using System;

namespace _005.ThirdDigit
{
    class ThirdDigit
    {
        static void Main()
        {
            string number = Console.ReadLine();

            if (number.Length <= 2)
            {
                Console.WriteLine("false 0");

            }
            else if (number[number.Length-3] == '7')
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}", number[number.Length - 3]);
            }
        }
    }
}
