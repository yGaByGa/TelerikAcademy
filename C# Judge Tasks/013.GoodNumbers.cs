using System;

namespace _013.GoodNumbers
{
    class GoodNumbers
    {
        static void Main()
        {
            int digit = 0;
            int count = 0;
            int a = 0;
            int countGoodNumbers = 0;

            string[] tokens = Console.ReadLine().Split();

            for (int i = Convert.ToInt32(tokens[0]); i <= Convert.ToInt32(tokens[1]); i++)
            {
                digit = i;
                a = digit;
                count = 0;

                while (a > 0)
                {
                    digit = a % 10;
                    if (digit != 0)
                    {
                        if (i % digit == 0)
                        {
                            count++;
                            if (count == Convert.ToInt32(Convert.ToString(i).Length))
                            {
                                countGoodNumbers++;
                            }
                        }
                    }
                    else
                    {
                        count++;
                    }
                    
                    a /= 10;
                }
            }
            Console.WriteLine(countGoodNumbers);
        }
    }
}
