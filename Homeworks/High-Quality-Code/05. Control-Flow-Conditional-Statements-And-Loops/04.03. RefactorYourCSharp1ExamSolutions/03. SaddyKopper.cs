////Task Description is in its respected file in same project
namespace ExamCSharp1Task3 
{
    using System;
    using System.Numerics;

    public class NumberTransformator
    {
        public const int MaxTransformations = 10;

        public static void Main()
        {
            BigInteger publicNumber = BigInteger.Parse(Console.ReadLine());
            BigInteger sumsProduct = 1;
            byte transformationCount = 0;

            //// loop of transformations
            for (byte index = 1; index <= MaxTransformations; index++)
            {
                if (transformationCount == 10)
                {
                    Console.WriteLine(publicNumber);
                    break;
                }
                else
                {
                    if (publicNumber < 10 && index > 1)
                    {
                        Console.WriteLine(transformationCount);
                        Console.WriteLine(publicNumber);
                        break;
                    }
                    else
                    {
                        sumsProduct = IterationCicle(publicNumber, sumsProduct);
                        publicNumber = sumsProduct;
                        transformationCount++;
                    }
                }
            }
        }

        /// <summary>
        /// removes the last digit (the rightmost one) from the number and
        /// then finds all digits at even positions (starting from zero) and finds their sum
        /// </summary>
        /// <param name="publicNumber">the magic number from the public</param>
        /// <param name="sumsProduct">the Product of all even sums</param>
        /// <returns></returns>
        public static BigInteger IterationCicle(BigInteger publicNumber, BigInteger sumsProduct)
        {
            while (publicNumber > 0)
            {        
                publicNumber /= 10;

                if (publicNumber == 0)
                {
                    break;
                }

                ////convert public number into string
                string stringNumber = Convert.ToString(publicNumber);
                int evenSum = 0;

                evenSum = GetSumAtEvenPosition(evenSum, stringNumber);

                ////reverse public number into Biginteger type again
                publicNumber = BigInteger.Parse(stringNumber);
                sumsProduct *= evenSum;
            }

            return sumsProduct;
        }

        public static int GetSumAtEvenPosition(int evenSum, string stringNumber)
        {
            for (int digit = 0; digit < stringNumber.Length; digit++)
            {
                if (digit % 2 == 0)
                {
                    evenSum += stringNumber[digit] - '0';
                }
            }

            return evenSum;
        }
    }
}