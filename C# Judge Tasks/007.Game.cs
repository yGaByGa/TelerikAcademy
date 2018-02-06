using System;

namespace _007.Game
{
    class Game
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int numberOne, numberTwo, numberThree = 0;
            int result1 = 0;
            int result2 = 0;
            int result3 = 0;
            int result4 = 0;

            numberOne = (n / 100) % 10;
            numberTwo = (n / 10) % 10;
            numberThree = (n / 1) % 10;

            result1 = numberOne + (numberTwo * numberThree);
            result2 = (numberOne * numberTwo) + numberThree;
            result3 = numberOne + numberTwo + numberThree;
            result4 = numberOne * numberTwo * numberThree;

            Console.WriteLine(Math.Max(Math.Max(result1, result2), Math.Max(result4, result3)));
        }
    }
}
