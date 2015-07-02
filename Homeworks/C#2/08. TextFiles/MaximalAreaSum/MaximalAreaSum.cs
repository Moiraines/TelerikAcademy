//Task 5
//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.
//Example:
//input	    output
//4 
//2 3 3 4 
//0 2 3 4 
//3 7 1 2 
//4 3 3 2	17
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
    class MaximalAreaSum
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\Task5Input.txt");
            ResultToFile(BestMatrix(ReadFromFileToList(reader), 2));
         
        }

        static int[,] ReadFromFileToList(StreamReader reader)
        {
            using (reader)
            {
                string line = reader.ReadLine();
                int n = int.Parse(line);
                int[,] array = new int[n, n];
                int counter = -1;
                while (true)
                {
                    line = reader.ReadLine();
                    counter++;
                    if (line == null)
                    {
                        break;
                    }
                    string[] splitedstring = line.Split(new char[] { ' ' });
                    for (int i = 0; i < n; i++)
                    {
                        array[counter, i] = int.Parse(splitedstring[i]);
                    }
                }
                return array;
            }
        }

        static int BestMatrix(int[,] matrix, int sizeOfSquare)
        {
            int sum;
            int bestSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    sum = 0;
                    for (int i = row; i < row + 2; i++)
                    {
                        for (int j = col; j < col + 2; j++)
                        {
                            sum += matrix[i, j];
                        }
                    }

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                    }
                }
            }

            return bestSum;
        }

        static void ResultToFile(int number)
        {
            StreamWriter streamWriter = new StreamWriter(@"..\..\task5Output.txt");
            using (streamWriter)
            {
                streamWriter.WriteLine(number);
          
                Console.WriteLine("The output file has been created");
            }
        }
    }
