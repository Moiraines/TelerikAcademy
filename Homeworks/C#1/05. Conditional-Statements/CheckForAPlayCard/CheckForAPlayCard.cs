//Task 3
//Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
//character	Valid card sign?
//5	yes
//1	no
//Q	yes
//q	no
//P	no
//10	yes
//500	no
using System;
    class CheckForAPlayCard
    {
        static void Main()
        {
            string sign = Console.ReadLine();

            if (sign == "Q" || sign == "J" || sign == "K" || sign == "A" || sign == "2" || sign == "3" || sign == "4" || sign == "5" || sign == "6" || sign == "7" || sign == "8" || sign == "9" || sign == "10")
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
