//Task 5
//Write an expression that checks for given integer if its third digit from right-to-left is 7
using System;
    class ThirdDigitIs7
    {
        static void Main()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            bool thirdDigit7;
            thirdDigit7 = (number / 100) % 10 == 7; 
            Console.WriteLine("The third digit from right-to left is 7? -> {0}", thirdDigit7);
        }
    }
