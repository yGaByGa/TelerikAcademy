using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003.NumberOfPages
{
    class NumberOfPages
    {
        static void Main()
        {
            int digits = int.Parse(Console.ReadLine());

            int pages = 0;

            //easy way
            for (int i = 0; digits > 0 ; i++)
            {
                pages++;
                digits -= i.ToString().Length;
            }

            //long way
            for (int i = 0; i < 2; i++)
            {
                if (digits <= 9)
                {
                    pages += digits / 1;
                    break;
                }
                else
                {
                    digits -= 9;
                    pages += 9;
                }

                if (digits <= 99)
                {
                    pages += digits / 2;
                    break;
                }
                else
                {
                    digits -= 180;
                    pages += 90;
                }

                if (digits <= 999)
                {
                    pages += digits / 3;
                    break;
                }
                else
                {
                    digits -= 2700;
                    pages += 900;
                }

                if (digits <= 9999)
                {
                    pages += digits / 4;
                    break;
                }
                else
                {
                    digits -= 36000;
                    pages += 9000;
                }

                if (digits <= 99999)
                {
                    pages += digits / 5;
                    break;
                }
                else
                {
                    digits -= 450000;
                    pages += 90000;
                }

                if (digits <= 999999)
                {
                    pages += digits / 6;
                    break;
                }
                else
                {
                    digits -= 5400000;
                    pages += 900000;
                }
            }
            Console.WriteLine(pages);
        }
    }
}
