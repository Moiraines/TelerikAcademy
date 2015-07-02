//Task 4
//Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).Use Windows Calculator to find its hexadecimal representation. Print the variable and ensure that the result is 254.
using System;
    class VariableInHexadecimalFormat
    {
        static void Main()
        {
            int hexadecimalnumber = 0xFE;
            Console.WriteLine(hexadecimalnumber);

            //Second Way
            //string variable = "FE";
            //int hecadecimal = int.Parse(variable, System.Globalization.NumberStyles.HexNumber);
            //Console.WriteLine(hecadecimal);
        }
    }