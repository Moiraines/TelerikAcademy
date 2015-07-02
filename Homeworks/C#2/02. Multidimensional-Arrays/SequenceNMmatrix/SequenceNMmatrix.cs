//Task 3
//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class SequenceNMmatrix
    {
        static void Main()
        {
            //Example for faster data input
            string[,] matrix =
            {
                { "ha", "fifi", "ho", "hi" },
                { "fo", "ha", "hi", "xx" },
                { "xxx", "ho", "ha", "xx" }
            };
            int maxSum = 0;
            string maxElement = "";
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (FindLongestSequence(matrix, row, col) > maxSum)
                    {
                        maxSum = FindLongestSequence(matrix, row, col);
                        maxElement = matrix[row, col];
                    } 
                }
            }

            PrintResult(maxSum, maxElement);
        }

        static int FindLongestSequence(string[,] matrix, int row, int col)
        {
            int maxSum = 0;
            int currentSum = 1;
            for (int i = row + 1; i < matrix.GetLength(0) - row; i++)
            {
                if (matrix[row, col] == matrix[i, col])
                {
                    currentSum++;
                }
                else
                {
                    break;
                }
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }

            currentSum = 1;
            for (int i = col + 1; i < matrix.GetLength(1) - col; i++)
            {

                if (matrix[row, col] == matrix[row, i])
                {
                    currentSum++;
                }
                else
                {
                    break;
                }
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }

            currentSum = 1;
            for (int i = row + 1, j = col + 1; (i < matrix.GetLength(0) - row) && j < (matrix.GetLength(1) - col); i++, j++)
            {
                if (matrix[row, col] == matrix[i, j])
                {
                    currentSum++;
                }
                else
                {
                    break;
                }
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }

            currentSum = 1;
            for (int i = row + 1, j = col - 1; (i < matrix.GetLength(0) - row) && j < (matrix.GetLength(1) - (matrix.GetLength(1) - col)); i++, j++)
            {
                if (col == 0)
                {
                    continue;
                }
                if (matrix[row, col] == matrix[i, j])
                {
                    currentSum++;
                }
                else
                {
                    break;
                }
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;

            }

            return maxSum;
        }


        static void PrintResult(int S, string element)
        {
            Console.WriteLine("Result:");
            for (int i = 0; i < S; i++)
            {
                Console.Write(element + (i != S - 1 ? ", " : ""));
            }
            Console.WriteLine();
        }

    }