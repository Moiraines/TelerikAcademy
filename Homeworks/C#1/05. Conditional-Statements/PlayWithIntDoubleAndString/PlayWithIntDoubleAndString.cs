//Task 9
//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.
//Example 1:

//program	user
//Please choose a type:	
//1 --> int	
//2 --> double	3
//3 --> string	
//Please enter a string:	hello
//hello*	
//Example 2:

//program	user
//Please choose a type:	
//1 --> int	
//2 --> double	2
//3 --> string	
//Please enter a double:	1.5
//2.5
using System;
    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            byte input;

            Console.WriteLine("Please choose a type:");
            bool correctNumber = byte.TryParse(Console.ReadLine(), out input);
            while (!correctNumber || (input < 1) || (input > 3))
            {
                Console.WriteLine("Invalid type. Please try again.");
                correctNumber = byte.TryParse(Console.ReadLine(), out input);
            }

            switch (input)
            {
                case 1:
                    {
                        Console.WriteLine("Please enter a int:");
                        int inputInt;

                        correctNumber = int.TryParse(Console.ReadLine(), out inputInt);
                        while (!correctNumber)
                        {
                            Console.WriteLine("Invalid input. Please try again.");
                            correctNumber = int.TryParse(Console.ReadLine(), out inputInt);
                        }

                        inputInt = inputInt + 1;
                        Console.WriteLine();
                        Console.WriteLine(inputInt);
                    }
                    break;

                case 2:
                    {
                        Console.WriteLine("Please enter a double:");
                        double inputDouble;

                        correctNumber = double.TryParse(Console.ReadLine(), out inputDouble);
                        while (!correctNumber)
                        {
                            Console.WriteLine("Invalid input. Please try again.");
                            correctNumber = double.TryParse(Console.ReadLine(), out inputDouble);
                        }

                        inputDouble = inputDouble + 1.0;
                        Console.WriteLine();
                        Console.WriteLine(inputDouble);
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine("Please enter a string:");
                        string inputString = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine(inputString + "*");
                    }
                    break;


                default: Console.WriteLine();
                    break;
            }

        }
    }
