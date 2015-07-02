//Task 13
//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
using System;
using System.Linq;
class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a binary number (only 0s or 1s): ");
        string number = Console.ReadLine();
        long decimalResult = 0;

        for (int i = 0; i < number.Length; i++)
        {
            decimalResult = (decimalResult << 1) + (number[i] == '1' ? 1 : 0);
        }
        Console.WriteLine();
        Console.WriteLine(decimalResult);

    }
}



            
            
