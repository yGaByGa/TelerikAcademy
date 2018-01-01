//Write a program that reads from the console a positive integer number N 
//and prints a matrix like in the examples below. Use two nested loops.


using System;

namespace _009.MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            //input
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n + (i - 1); j++)
                {
                    //output
                    Console.Write("{0} ", j);
                }
                //new line
                Console.WriteLine();
            }
        }
    }
}
