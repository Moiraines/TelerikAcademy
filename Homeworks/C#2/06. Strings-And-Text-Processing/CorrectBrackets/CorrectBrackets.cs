//Task 3
//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b))
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class CorrectBrackets
    {
        static void Main()
        {
            Console.WriteLine("Enter an expression for evaluation: ");
            string input = Console.ReadLine();

            Stack<char> stash = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stash.Push(input[i]);
                }
                else if (input[i] == ')')
                {
                    if (stash.Contains('('))
                    {
                        stash.Pop();
                    }
                    else
                    {
                        Console.WriteLine("It's not a correct expression");
                        Environment.Exit(0);
                    }
                }
            }

            if (stash.Count == 0)
            {
                Console.WriteLine("It's a correct expression");
            }
            else
            {
                Console.WriteLine("It's not a correct expression");
            }
            
        }
    }
