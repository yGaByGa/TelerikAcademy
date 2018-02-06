using System;

namespace _010.MinMaxSumAverage
{
    class MinMaxSumAverage
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());

            double max = -100000;
            double min = 100000;
            double avg = 0;
            double sum = 0;

            for (int i = 0 ; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                sum = sum + number;
                if (min > number)
                {
                    min = number;
                }
                if (max < number)
                {
                    max = number;
                }
            }
            
            avg = sum / n;

            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", avg);
        }
    }
}
