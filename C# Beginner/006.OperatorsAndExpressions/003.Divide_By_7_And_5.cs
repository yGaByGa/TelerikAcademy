//Write a program that does the following:
//Reads an integer number from the console.
//Stores in a variable if the number can be divided by 7 and 5 without remainder.

using System;

namespace _003.Divide_By_7_And_5
{
    class Divide_By_7_And_5
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if ((number % 5 == 0) && (number % 7 == 0))
            {
                Console.WriteLine("true {0}", number);
            }
            else
            {
                Console.WriteLine("false {0}", number);
            }
        }
    }
}
