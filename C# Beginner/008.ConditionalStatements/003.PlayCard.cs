//Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
//Write a program that enters a string and prints "yes CONTENT_OF_STRING" if it is a valid card sign 
//or "no CONTENT_OF_STRING" otherwise.

using System;

namespace _003.PlayCard
{
    class PlayCard
    {
        static void Main()
        {
            bool yes = false;
            string[] cardArray = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};

            string input = Console.ReadLine();

            for (int i = 0; i < cardArray.Length ; i++)
            {
                if (input == cardArray[i])
                {
                    Console.WriteLine("yes {0}", cardArray[i]);
                    yes = true;
                }
            }
            if (yes == false)
            {
                Console.WriteLine("no {0}", input);
            }
        }
    }
}
