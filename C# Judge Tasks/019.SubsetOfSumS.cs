using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019.SubsetOfSumS
{
    class SubsetOfSumS
    {
        static void Main()
        {
            int result = 0;
            int ckeck = 0;

            int s = int.Parse(Console.ReadLine());
            string[] lineNumbers = Console.ReadLine().Split();
            ckeck = s;

            for (int i = 0; i < lineNumbers.Length; i++)
            {
                if (Convert.ToInt32(lineNumbers[i]) <= ckeck )
                {
                    ckeck -= Convert.ToInt32(lineNumbers[i]);
                }
                if (ckeck == 0)
                {
                    Console.WriteLine("yes");
                    return;
                }
            }

            for (int i = 0; i < lineNumbers.Length; i++)
            {
                for (int j = 0; j < lineNumbers.Length; j++)
                {
                    if (i != j)
                    {
                        result += Convert.ToInt32(lineNumbers[j]);
                        if (result == s)
                        {
                            Console.WriteLine("yes");
                            return;
                        }
                    }
                }
                result = 0;
            }

            Array.Reverse(lineNumbers);

            for (int i = 0; i < lineNumbers.Length; i++)
            {
                for (int j = 0; j < lineNumbers.Length; j++)
                {
                    if (i != j)
                    {
                        result += Convert.ToInt32(lineNumbers[j]);
                        if (result == s)
                        {
                            Console.WriteLine("yes");
                            return;
                        }
                    }
                }
                result = 0;
            }
            Console.WriteLine("no");
        }
    }
}
