//Task 1
//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class AllocateArray
    {
        static void Main()
        {
            int[] myArray = new int[20];
            Console.Write("intArray[20] = ");
            for (int index = 0; index < myArray.Length; index++)
            {
                myArray[index] = index * 5;
                Console.Write("{0}, ", myArray[index]);
            }
            Console.WriteLine();
        }
    }
