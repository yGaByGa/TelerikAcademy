//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

namespace _003.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            int symbolToCompare = first.Length < second.Length ? first.Length : second.Length;
            string isEqual = "=";
            for (int i = 0; i < symbolToCompare; i++)
            {
                if (first[i] < second[i])
                {
                    isEqual = "<";
                    break;
                }

                if (first[i] > second[i])
                {
                    isEqual = ">";
                    break;
                }

            }
            if (isEqual == "=")
            {
                if (first.Length < second.Length) isEqual = "<";
                if (first.Length > second.Length) isEqual = ">";
            }
            Console.WriteLine(isEqual);
        }
    }
}
