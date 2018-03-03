using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Buses
{
    class Buses
    {
        static void Main()
        {
            int countGroups = 0;
            int index = 0;

            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < n; i++)
            {
                if (array[index] >= array[i])
                {
                    countGroups += 1;
                    index = i;
                }
            }
            Console.WriteLine(countGroups + 1);
        }
    }
}
