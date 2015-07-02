//Task 1
//Write a program that fills and prints a matrix of size (n, n) as shown below:
//Example for n=4:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class FillTheMatrix
    {
        static void Main()
        {
            Console.WriteLine("Please enter a size for the matrix:");
            int n = int.Parse(Console.ReadLine());
        
            int[,] matrix = new int[n, n];

            Console.WriteLine("Please choose an option between a, b, c or d:");
            string option = Console.ReadLine();

            switch (option)
            {
                case "a":
                    {
                        MatrixA(matrix, n);
                    }
                    break;
                case "b":
                    {
                        MatrixB(matrix, n);
                    }
                    break;
                case "c":
                    {
                        MatrixC(matrix, n);
                    }
                    break;
                case "d":
                    {
                        MatrixD(matrix, n);
                    }
                    break;
                default:
                    {
                        while (option != "a" && option != "b" && option != "c" && option != "d")
                        {
                            Console.WriteLine("Invalid choice\nTry again: ");
                            option = Console.ReadLine();
                        }
                    }
                    break;

            }

        }

        static void MatrixA(int[,] matrix, int n)
        {
            int counter;
            for (int row = 0; row < n; row++)
            {
                counter = row + 1;
                for (int cols = 0; cols < n; cols++)
                {
                    matrix[row, cols] = counter;
                    counter += n;
                }
            }
            PrintMatrix(matrix);
        }

        static void MatrixB(int[,] matrix, int n)
        {
            int counter;
            for (int row = 0; row < n; row++)
            {
                counter = row + 1;
                for (int cols = 0; cols < n; cols+=2)
                {
                    matrix[row, cols] = counter;
                    counter += n * 2;
                }
            }

            for (int row = n - 1; row >= 0; row--)
            {
                counter = 2* n - row;
                for (int cols = 1; cols < n; cols+=2)
                {
                    matrix[row, cols] = counter;
                    counter += n * 2;
                }
            }

            PrintMatrix(matrix);
        }

        static void MatrixC(int[,] matrix, int n)
        {
            int rowCounter;
            int colCounter;
            int numCounter = 1;
            for (int i = 0; i < n; i++)
            {
                rowCounter = i;
                colCounter = 0;
                for (int j = 0; j <= i; j++)
                {
                    matrix[rowCounter, colCounter] = numCounter;
                    numCounter++;
                    rowCounter--;
                    colCounter++;
                }
            }

            int numCounter2 = n * n;
            for (int i = 1; i < n; i++)
            {
                rowCounter = n - i;
                colCounter = 3;
                for (int j = 1; j <= i; j++)
                {
                    matrix[rowCounter, colCounter] = numCounter2;
                    numCounter2--;
                    rowCounter++;
                    colCounter--;
                }
            }

            //create a new array with reverse rows.
            int counter3 = 0;
            int[,] matrixNew = new int [n,n];
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    matrixNew[counter3, j] = matrix[i,j];        
                }
                counter3++;
            }

            PrintMatrix(matrixNew);
        }

        static void MatrixD(int[,] matrix, int n)
        {
            int rowCounter = n - 1;
            int colCounter = 0;
            int numCounter = 1;

            //loop for filling the first coloumn
            for (int i = 0; i < n; i++)
            {
                matrix[i, colCounter] = numCounter;
                numCounter++;
            }

            for (int iteration = 1; iteration < n; iteration++)
            {
                
                for (int j = 0; j < n - iteration; j++)
                {
                    if (iteration % 2 != 0)
                    {
                        colCounter++;
                    }
                    else
                    {
                        colCounter--;
                    }
                    matrix[rowCounter, colCounter] = numCounter;
                    numCounter++;
                }

                for (int i = 0; i < n - iteration; i++)
                {
                    if (iteration % 2 != 0 )
                    {
                        rowCounter--;
                    }
                    else
                    {
                        rowCounter++;
                    }
                    
                    matrix[rowCounter, colCounter] = numCounter;
                    numCounter++;
                }
            }

            PrintMatrix(matrix);
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,3} ", matrix[row, col]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }
