//Task 6
//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following: Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4). Prints on the console the number in reversed order: dcba (in our example 1102). Puts the last digit in the first position: dabc (in our example 1201). Exchanges the second and the third digits: acbd (in our example 2101).The number has always exactly 4 digits and cannot start with 0.
using System;
    class FourDigitNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter a number in a four-digit format: ");
            int number;
            bool incorrectNumber = int.TryParse(Console.ReadLine(), out number);
            while ((!incorrectNumber) || (number < 1000) || (number > 9999))
            {
                Console.WriteLine("Invalid number.\nTry again: ");
                incorrectNumber = int.TryParse(Console.ReadLine(), out number);
            }
            byte firstDigit = (byte)(number / 1000);
            byte secondDigit = (byte)((number / 100) % 10);
            byte thirdDigit = (byte)((number / 10) % 10);
            byte fourthDigit = (byte)(number % 10);
            byte sum = (byte)(firstDigit + secondDigit + thirdDigit + fourthDigit);

            Console.WriteLine("Calculates the sum of the digits : {0}", sum);
            Console.WriteLine("Prints on the console the number in reversed order: {0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);
            Console.WriteLine("Puts the last digit in the first position: {0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thirdDigit);
            Console.WriteLine("Exchanges the second and the third digits: {0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit);
        }
    }