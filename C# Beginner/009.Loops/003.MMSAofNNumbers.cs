using System;

namespace _003.MMSAofNNumbers
{
    class MMSAofNNumbers
    {
        static void Main()
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal sum = 0;
            decimal avg = 0;
            decimal min = 100100;
            decimal max = -100000;
            decimal number = 0;

            for (int i = 1; i <= n; i++)
            {
                number = decimal.Parse(Console.ReadLine());
                sum += number;

                if (min > number)
                {
                    min = number;
                }
                if (max < number)
                {
                    max = number;
                }
                avg = sum / n;
            }
            Console.WriteLine("min={0:f2}", min);
            Console.WriteLine("max={0:f2}", max);
            Console.WriteLine("sum={0:f2}", sum);
            Console.WriteLine("avg={0:f2}", avg);
        }
    }
}
