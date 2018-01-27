////Write a program that, depending on the first line of the input, reads an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends* at the end.
//Print the result at the console. Use switch statement.

using System;

namespace _009.IntDoubleString
{
    class IntDoubleString
    {
        static void Main()
        {
            string type = Console.ReadLine();
            double num = 0;

            switch (type)
            {
                case "integer":
                    num = double.Parse(Console.ReadLine());
                    Console.WriteLine(num + 1);
                    break;
                case "real":
                    num = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}", num + 1);
                    break;
                case "text":
                    string text = Console.ReadLine();
                    Console.WriteLine(text + "*");
                    break;
                default:
                    break;
            }
        }
    }
}
