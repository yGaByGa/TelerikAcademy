﻿//Write a program that read a digit [0-9] from the console, and depending on the input, shows the digit as a word (in English).

using System;

namespace _008.DigitAsWord
{
    class DigitAsWord
    {
        static void Main()
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("one");
                    break;
                case "2":
                    Console.WriteLine("two");
                    break;
                case "3":
                    Console.WriteLine("three");
                    break;
                case "4":
                    Console.WriteLine("four");
                    break;
                case "5":
                    Console.WriteLine("five");
                    break;
                case "6":
                    Console.WriteLine("six");
                    break;
                case "7":
                    Console.WriteLine("seven");
                    break;
                case "8":
                    Console.WriteLine("eight");
                    break;
                case "9":
                    Console.WriteLine("nine");
                    break;
                case "0":
                    Console.WriteLine("zero");
                    break;
                default:
                    Console.WriteLine("not a digit");
                    break;
            }
        }
    }
}
