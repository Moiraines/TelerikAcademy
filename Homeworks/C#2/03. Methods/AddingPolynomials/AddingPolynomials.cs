//Task 11
//Write a method that adds two polynomials.
//Represent them as arrays of their coefficients.
//Example:
//x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class AddingPolynomials
    {
        static void Main()
        {
            Console.WriteLine("Enter the degree of your first polynomial:");
            int degree1 = int.Parse(Console.ReadLine());
            int[] firstPolynomial = new int[degree1 + 1];
            for (int i = 0; i < degree1 + 1; i++)
            {
                Console.WriteLine("Enter your X^{0} coefficient", i);
                firstPolynomial[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the degree of your second polynomial:");
            int degree2 = int.Parse(Console.ReadLine());
            int[] secondPolynomial = new int[degree2 + 1];
            for (int i = 0; i < degree2 + 1; i++)
            {
                Console.WriteLine("Enter your X^{0} coefficient", i);
                secondPolynomial[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine(PrintPolynomial(firstPolynomial));
            Console.WriteLine("+");
            Console.WriteLine(PrintPolynomial(secondPolynomial));
            Console.WriteLine("=");
            int[] arrSum = AddPolynomials(firstPolynomial, secondPolynomial);
            string result = PrintPolynomial(arrSum);

            if (result[0].Equals('+') || result[0].Equals('-'))
            {
                result = result.Remove(0, 1);
            }
            Console.WriteLine(result);
            
        }

        static int[] AddPolynomials(int[] arr1, int[] arr2)
        {
            int max = arr1.Length;
            if (arr1.Length < arr2.Length)
            {
                max = arr2.Length;
            }

            int[] arrSum = new int[max];
            for (int i = 0; i < max; i++)
            {
                if (i == arr1.Length)
                {
                    for (int j = arr1.Length; j < max; j++)
                    {
                        arrSum[j] = arr2[j];
                    }
                    break;
                }

                if (i == arr2.Length)
                {
                    for (int j = arr2.Length; j < max; j++)
                    {
                        arrSum[j] = arr1[j];
                    }
                    break;
                }

                arrSum[i] += (arr1[i] + arr2[i]);
            }
            return arrSum;
        }

        static string PrintPolynomial(int[] arr)
        {
            string result = null;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == 0)
                {
                    continue;
                }
                else if (arr[i] == 1 ||arr[i] == -1)
                {
                    if (i == arr.Length - 1)
	                {
                        result += (arr[i] > 0 ? "x^" : "-x^") + i;
	                }
                    else if (i == 0)
                    {
                        result += (arr[i] > 0 ? "+" : "") + arr[i];
                    }
                    else
                    {
                        result += (arr[i] > 0 ? "+x^" : "-x^") + i;
                    }
                }
                else
                {
                    if (i == arr.Length - 1)
                    {
                        result += arr[i] + "x^" + i;
                    }
                    else if (i == 0)
	                {
                        result += (arr[i] > 0 ? "+" : "") + arr[i];
	                }
                    else
                    {
                        result += (arr[i] > 0 ? "+" : "") + arr[i] + "x^" + i;
                    }
                }
            }
            return result;
        }
    }
