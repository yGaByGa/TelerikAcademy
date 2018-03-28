using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028.ThreeGroups
{
    class ThreeGroups
    {
        static void Main()
        {
            string[] allnumbers = Console.ReadLine().Split();

            int[] rem0 = new int[allnumbers.Length];
            int[] rem1 = new int[allnumbers.Length];
            int[] rem2 = new int[allnumbers.Length];

            int count0 = 0;
            int count1 = 0;
            int count2 = 0;

            for (int i = 0; i < allnumbers.Length; i++)
            {
                if (Convert.ToInt32(allnumbers[i]) % 3 == 0)
                {
                    rem0[count0] = Convert.ToInt32(allnumbers[i]);
                    count0++;
                }
                else if (Convert.ToInt32(allnumbers[i]) % 3 == 1)
                {
                    rem1[count1] = Convert.ToInt32(allnumbers[i]);
                    count1++;
                }
                else if (Convert.ToInt32(allnumbers[i]) % 3 == 2)
                {
                    rem2[count2] = Convert.ToInt32(allnumbers[i]);
                    count2++;
                }
            }

            foreach (var x in rem0)
            {
                if (x != 0)
                {
                    Console.Write(x + " ");
                }
            }
            Console.WriteLine();
            foreach (var x in rem1)
            {
                if (x != 0)
                {
                    Console.Write(x + " ");
                }
            }
            Console.WriteLine();
            foreach (var x in rem2)
            {
                if (x != 0)
                {
                    Console.Write(x + " ");
                }
            }

            //Console.WriteLine(String.Join(" ", rem0));
            //Console.WriteLine(String.Join(" ", rem1));
            //Console.WriteLine(String.Join(" ", rem2));
        }
    }
}
