using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017.SecretMessage
{
    class SecretMessage
    {
        static void Main()
        {
            string[] charForRemove = { "0", "1", "2" ,"3", "4", "5", "6", "7", "8" ,"9" };

            string text = Console.ReadLine();

            string text2 = String.Empty;
            for (int i = text.Length - 1; i > -1; i--)
            {
                text2 += text[i];
            }

            string[] roadArray = text2.Split(charForRemove, System.StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(String.Join("", roadArray));
        }
    }
}
