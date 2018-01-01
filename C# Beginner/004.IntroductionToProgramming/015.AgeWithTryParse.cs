//Write a program that reads your birthday(in the format MM.DD.YYYY) from the console and prints on 
//the console how old you are you now and how old will you be after 10 years.

using System;

namespace _015.AgeWithTryParse
{
    class AgeWithTryParse
    {
        static void Main()
        {
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Now;
            int currentage = today.Year - birthday.Year;

                Console.WriteLine(currentage);
                Console.WriteLine(currentage + 10);
        }
    }
}
