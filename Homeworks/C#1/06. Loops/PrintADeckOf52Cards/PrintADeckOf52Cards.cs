//Task 4
//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
using System;
    class PrintADeckOf52Cards
    {
        static void Main()
        {
            for (int i = 2; i <= 14; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    switch (i)
                    {
                        case 11: Console.Write("J");
                            break;
                        case 12: Console.Write("Q");
                            break;
                        case 13: Console.Write("K");
                            break;
                        case 14: Console.Write("A");
                            break;
                        default: Console.Write(i);
                            break;
                    }
                    switch (j)
                    {
                        case 1: Console.Write(" of spades, ");
                            break;
                        case 2: Console.Write(" of clubs, ");
                            break;
                        case 3: Console.Write(" of hearts, ");
                            break;
                        case 4: Console.Write(" of diamods");
                            break;
                        default:
                            break;
                    }
                }

                Console.WriteLine();
            }

        }
    }
