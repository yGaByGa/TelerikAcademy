//Write a program that creates an array containing all letters from the alphabet (a-z). 
//Read a word from the console and print the index of each of its letters in the array.

using System;

namespace _012.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            char[] array = new char[] 
            {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
                'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
                'w', 'x', 'y', 'z'
            };

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (input[i] == array[j])
                    {
                        Console.WriteLine(j);
                    }
                }
            }
        }
    }
}
