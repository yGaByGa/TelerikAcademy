//Find online more information about ASCII (American Standard Code for Information Interchange) 
//and write a program that prints the visible characters of the ASCII table on the console (characters from 33 to 126 including).

using System;
using System.Collections.Generic;

namespace _014.PrintTheASCIITable
{
    class PrintTheASCIITable
    {
        static void Main()
        {
            for (int i = 33; i < 127; i++)
            {
                char c = Convert.ToChar(i);

                Console.Write(c);
            }
        }
    }
}
