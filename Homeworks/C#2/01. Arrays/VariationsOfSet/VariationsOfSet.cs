﻿//Task 20
//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class VariationsOfSet
    {
        static void Main()
        {
            Console.WriteLine("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine();
            

            int[] digit = new int[k];

            //set initial digits to 1, except the k digit
            for (int i = 0; i < k - 1; i++)
                digit[i] = 1;

            Console.WriteLine("Variations: ");
            bool finish = false;
            while (!finish)
            {
                //start digit incremention from last
                for (int i = k - 1; i >= 0; i--)
                {
                    digit[i]++;

                    if (digit[i] > n)
                    {
                        digit[i] = 1;
                    }

                    else break;

                }

                for (int i = 0; i < k; i++)
                {
                    if (i == 0)
                    {
                        Console.Write("{" + digit[i] + ", ");
                    }
                    else if (i == k - 1)
                    {
                        Console.Write(digit[i] + "}");
                    }
                    else
                    {
                        Console.Write(digit[i] + ", ");
                    }
                }
                    
                Console.WriteLine();

                for (int i = 0; i < k; i++)
                {
                    if (digit[i] != n)
                    {
                        finish = false; break;
                    }
                    else 
                    {
                        finish = true;
                    } 
                }
            }

        }
    }
