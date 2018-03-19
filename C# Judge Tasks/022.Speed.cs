using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022.Speed
{
    class Speed
    {
        static void Main()
        {
            int result = 0;
            int maxResult = 0;
            int count = 0;

            bool check = true;

            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[0] == array[i])
                {
                    count++;
                }
                if (count == array.Length)
                {
                    Console.WriteLine(array[0]);
                    count = 0;
                    return;
                }
            }

            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    if (check == true)
                    {
                        result = array[i] + array[i + 1];
                        check = false;
                    }
                    else
                    {
                        result += array[i + 1];
                    }

                    if (result > maxResult)
                    {
                        maxResult = result;
                    }
                }
                else
                {
                    if (array[i] > array[i + 1])
                    {
                        count++;
                        if (count == array.Length - 1)
                        {
                            Console.WriteLine(array[0]);
                            count = 0;
                            return;
                        }
                    }
                    else
                    {
                        check = true;
                    }
                    result = 0;
                }
            }
            Console.WriteLine(maxResult);
        }
    }
}
