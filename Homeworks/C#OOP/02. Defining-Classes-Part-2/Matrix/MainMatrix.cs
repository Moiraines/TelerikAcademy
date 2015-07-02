using System;
namespace Matrix
{
    class MainMatrix
    {
        static void Main()
        {


            Matrix<int> matrix1 = new Matrix<int>(3, 3); //two matrices for testing +, - and *
            Matrix<int> matrix2 = new Matrix<int>(3, 3);

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Cols; j++)
                {
                    matrix1[i, j] = (i + 3) * (j + 1) + 5;
                    matrix2[i, j] = (i + 1) * (j + 2);
                }
            }

            Console.WriteLine("Matrix 1:\n{0}", matrix1);
            Console.WriteLine("Matrix 2:\n{0}", matrix2);

            Matrix<int> resultOfAddition = matrix1 + matrix2;
            Matrix<int> resultOfSubtraction = matrix1 - matrix2;
            Matrix<int> resultOfMultiplication = matrix1 * matrix2;

            Console.WriteLine("Matrix1 + Matrix2 =\n{0}", resultOfAddition);
            Console.WriteLine("Matrix1 - Matrix2 =\n{0}", resultOfSubtraction);
            Console.WriteLine("Matrix1 * Matrix2 =\n{0}", resultOfMultiplication);

            //testing true/false
            if (matrix1)
            {
                Console.WriteLine("{0} does not contain zero elements", matrix1);
            }
            else
            {
                Console.WriteLine("{0} contains zero element(s)");
            }

            matrix1[0, 0] = 0;

            if (matrix1)
            {
                Console.WriteLine("{0} does not contain zero elements", matrix1);
            }
            else
            {
                Console.WriteLine("{0} contains zero element(s)", matrix1);
            }
        }
    }
}
