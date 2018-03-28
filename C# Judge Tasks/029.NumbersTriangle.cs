using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029.NumbersTriangle
{
    class NumbersTriangle
    {
        static void Main()
        {
            bool check = true;

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n * 2 - 1; i++)
            {
                if (i <= n && check)
                {
                    for (int j = 1; j < i + 1; j++)
                    {
                        Console.Write(j + " ");
                    }
                }
                else
                {
                    check = false;
                    for (int j = 1; j < n * 2 - i + 1; j++)
                    {
                        Console.Write(j + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
