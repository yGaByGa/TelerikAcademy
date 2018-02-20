//Write a program that finds the most frequent number in an array of N elements.

using System;

namespace _009.FrequentNumber
{
    class FrequentNumber
    {
        static void Main()
        {
            int number = 0;
            int countNumber = 0;
            int lastNumber = 0;
            int lastCount = 0;

            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (array[j] == array[i])
                    {
                        countNumber += 1;
                        number = array[j];
                    }
                    if (countNumber > lastCount)
                    {
                        lastCount = countNumber;
                        lastNumber = number;
                    }
                }
                countNumber = 0;
            }
            Console.WriteLine("{0} ({1} times)", lastNumber ,lastCount);
        }
    }
}
