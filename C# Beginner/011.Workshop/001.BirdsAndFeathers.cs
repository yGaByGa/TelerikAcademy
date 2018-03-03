using System;

namespace _001.BirdsAndFeathers
{
    class BirdsAndFeathers
    {
        static void Main()
        {
            double result = 0;
            double avg;

            int birds = int.Parse(Console.ReadLine());
            int feathers = int.Parse(Console.ReadLine());

            if (birds != 0)
            {
                avg = feathers / (double)birds;

                if (birds % 2 == 0)
                {
                    result = avg * 123123123123;
                }
                else
                {
                    result = avg / 317;
                }
            }
            Console.WriteLine("{0:F4}", result);
        }
    }
}
