//Task 2
//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class MaximalSum
    {
        static void Main()
        {
            Console.WriteLine("Please enter number of rows:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number of columns:");
            int columns = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Enter [{0}, {1}] element", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //Example for faster data input
            //int[,] matrix =
            //{
            //    { 0, 2, 4, 0, 9, 5 },
            //    { 7, 1, 3, 3, 2, 1 },
            //    { 1, 3, 9, 8, 5, 6 },
            //    { 4, 6, 7, 9, 1, 0 }
            //};

            int bestRow = 0;
            int bestCol = 0;
            int bestSum = int.MinValue;
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    for (int i = row; i < row + 3; i++)
                    {
                        for (int j = col; j < col + 3; j++)
                        {
                            sum += matrix[i, j];
                        }
                    }

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }

            //print the matrix

            Console.WriteLine("The best platform is:");
            for (int row = bestRow; row < bestRow + 3; row++)
            {
                for (int col = bestCol; col < bestCol + 3; col++)
                {
                    Console.Write("{0,3} ", matrix[row, col]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("The maximal sum is: {0}", bestSum);
        }
    }

