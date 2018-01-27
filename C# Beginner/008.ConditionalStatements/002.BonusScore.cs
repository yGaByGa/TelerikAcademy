//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is less than 0 or more than 9, the program prints "invalid score".

using System;

namespace _002.BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            if (n <= 9 && n >= 7)
            {
                Console.WriteLine(n * 1000);
            }
            else if (n <= 6 && n >= 4)
            {
                Console.WriteLine(n * 100);
            }
            else if (n <= 3 && n >= 1)
            {
                Console.WriteLine(n * 10);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
