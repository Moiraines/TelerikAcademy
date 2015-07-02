//Task 6
//Write a class Matrix, to hold a matrix of integers. Overload the operators for adding, subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class MatrixClass
    {
        static void Main()
        {
            Matrix myMatrix1 = new Matrix(2, 2);
            myMatrix1[0, 0] = 1;
            myMatrix1[1, 1] = -12;
            Matrix myMatrix2 = new Matrix(2, 2);

            myMatrix2[0, 1] = 2;
            myMatrix2[1, 1] = 24;

            Console.WriteLine("Sum of the matricies:");
            Matrix sum = myMatrix1 + myMatrix2;
            Console.WriteLine(sum.ToString());

            Console.WriteLine("Substract of the matricies:");
            Matrix substract = myMatrix1 - myMatrix2;
            Console.WriteLine(substract.ToString());

            Console.WriteLine("Multiplying of the matricies:");
            Matrix multiplying = myMatrix1 * myMatrix2;
            Console.WriteLine(multiplying.ToString());
        }
    }
