using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020.CrookedDigits
{
    class CrookedDigits
    {
        static void Main(string[] args)
        {
            string[] charForRemove = { ".", " ", ",", "-" };
            string text = Console.ReadLine();
            string[] roadArray = text.Split(charForRemove, System.StringSplitOptions.RemoveEmptyEntries);

            string number = string.Empty;
            int result = 0;

            for (int i = 0; i < roadArray.Length; i++)
            {
                number += roadArray[i];
            }

            if (number.Length == 1)
            {
                Console.WriteLine(number);
                return;
            }

            for (int i = 0; i <= number.Length; i++)
            {
                for (int j = 0; j < number.Length; j++)
                {
                    if (number.Length > 1)
                    {
                        result += number[j] - '0';
                    }
                }

                if (number.Length != 1)
                {
                    number = Convert.ToString(result);
                }
                if (number.Length == 1)
                {
                    Console.WriteLine(number);
                    break;
                }
                result = 0;
            }




            //EASY WAY
            //var n = Console.ReadLine();

            //while (n.Length > 1)
            //{
            //    long result = 0;

            //    for (int i = 0; i < n.Length; i++)
            //    {
            //        if (Char.IsDigit(n[i]))
            //        {
            //            result += int.Parse(n[i].ToString());
            //        }
            //    }
            //    n = result.ToString();
            //}
            //Console.WriteLine(n);
        }
    }
}