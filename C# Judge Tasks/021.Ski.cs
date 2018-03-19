using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021.Ski
{
    class Ski
    {
        static void Main()
        {
            int result = 0;
            int maxResult = 0;

            string inputNandL = Console.ReadLine();

            int n = inputNandL[0] - '0';
            int l = inputNandL[2] - '0';
            int newL = 0;
            int calculate = 0;

            string[] way = Console.ReadLine().Split();
            string[] bonbons = Console.ReadLine().Split();

            for (int i = 0; i < way.Length - 1; i++)
            {
                newL = l;
                bool check = true;
                for (int j = i; j < way.Length - 1; j++)
                {
                    calculate = Math.Abs((Convert.ToInt32(way[j]) - Convert.ToInt32(way[j + 1])));
                    
                    newL -= calculate;

                    if (newL >= 0)
                    {
                        if (check == true)
                        {
                            result += Convert.ToInt32(bonbons[j]) + Convert.ToInt32(bonbons[j + 1]);
                            check = false;
                        }
                        else
                        {
                            result += Convert.ToInt32(bonbons[j + 1]);
                        }
                        
                        if (result > maxResult)
                        {
                            maxResult = result;
                        }
                    }

                    if (calculate < 0)
                    {
                        result = 0;
                        break;
                    }
                }
                result = 0;
            }
            Console.WriteLine(maxResult);
        }
    }
}
