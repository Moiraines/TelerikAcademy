//Task 12
//Extend the previous program to support also subtraction and multiplication of polynomials.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class SubtractingPolynomials
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
            Console.WriteLine("First Polinomial: ");
            Console.WriteLine(PrintPolynomial(firstPolynomial));
            Console.WriteLine();
            Console.WriteLine("Second Polinomial ");
            Console.WriteLine(PrintPolynomial(secondPolynomial));
            Console.WriteLine();
            string result = null;
            Console.WriteLine("Enter a choose between a, b or c for execute adding, substraction or multiplication: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "a":
                    {
                       int[] arrSum = AddPolynomials(firstPolynomial, secondPolynomial);
                       result = PrintPolynomial(arrSum);
                    }
                    break;
                case "b":
                    {
                        int[] arrSum = SubtractPolynomials(firstPolynomial, secondPolynomial);
                        result = PrintPolynomial(arrSum);
                    }
                    break;
                case "c":
                    {
                        int[] arrSum = MultiplicatePolynomials(firstPolynomial, secondPolynomial);
                        result = PrintPolynomial(arrSum);
                    }
                    break;
                default: 
                    {
                        while (option != "a" && option != "b" && option != "c")
                        {
                            Console.WriteLine("Invalid choice\nTry again: ");
                            option = Console.ReadLine();
                        }
                    }
                    break;
            }

            
            if (result[0].Equals('+') || result[0].Equals('-'))
            {
                result = result.Remove(0, 1);
            }

            Console.WriteLine("The result is:\n{0}", result);

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
                        arrSum[j] = -arr2[j];
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

                arrSum[i] += (arr1[i] - arr2[i]);
            }
            return arrSum;
        }

        static int[] SubtractPolynomials(int[] arr1, int[] arr2)
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

        static int[] MultiplicatePolynomials(int[] arr1, int[] arr2)
        {
            int max = arr1.Length;
            if (arr1.Length < arr2.Length)
            {
                max = arr2.Length;
            }

            int[] arrSum = new int[max];
            for (int i = 0; i < max; i++)
            {
                if (i == arr1.Length || i == arr2.Length)
                {
                    arrSum[i] = 0;
                    break;
                }

                arrSum[i] += (arr1[i] * arr2[i]);
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
                else if (arr[i] == 1 || arr[i] == -1)
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
