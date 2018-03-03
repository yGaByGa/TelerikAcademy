using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018.Password
{
    class Password
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            string number = input[0];
            int k = Convert.ToInt32(input[1]);

            string change = Convert.ToString(number[5]) + number[4] + number[3] + number[2] + number[1] + number[0];

            int deleno = Convert.ToInt32(change) / k;
            int ostatyk = Convert.ToInt32(change) % k;

            Console.WriteLine(deleno + ostatyk);
        }
    }
}
