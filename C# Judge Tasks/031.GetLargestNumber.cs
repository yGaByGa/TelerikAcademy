using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031.GetLargestNumber
{
    class GetLargestNumber
    {
        static void Main()
        {
            int biggest = -2000000;
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                if (Convert.ToInt32(input[i]) > biggest)
                {
                    biggest = Convert.ToInt32(input[i]);
                }
            }
            Console.WriteLine(biggest);
        }
    }
}
