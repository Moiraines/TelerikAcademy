//Task 11
//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
using System;
    class NumberAsWords
    {
        static void Main()
        {
            ushort number;

            Console.WriteLine("Enter na number:");
            bool correctNumber = ushort.TryParse(Console.ReadLine(), out number);
            while (!correctNumber || (number < 0) || (number > 999))
            {
                Console.WriteLine("Invalid number. Please try again.");
                correctNumber = ushort.TryParse(Console.ReadLine(), out number);
            }
            ushort firstDigit;
            ushort secondDigit;
            ushort thirdDigit;

            if ((number >= 100) && (number <= 999))
            {
                firstDigit = (ushort)(number / 100);
                secondDigit = (ushort)((number / 10) % 10);
                thirdDigit = (ushort)(number % 10);

                switch (firstDigit)
                {
                    case 1: Console.Write("One hundred ");
                        break;
                    case 2: Console.Write("Two hundred ");
                        break;
                    case 3: Console.Write("Three hundred ");
                        break;
                    case 4: Console.Write("Four hundred ");
                        break;
                    case 5: Console.Write("Five hundred ");
                        break;
                    case 6: Console.Write("Six hundred ");
                        break;
                    case 7: Console.Write("Seven hundred ");
                        break;
                    case 8: Console.Write("Eight hundred ");
                        break;
                    case 9: Console.Write("Nine hundred ");
                        break;
                    default:
                        break;
                }

                switch (secondDigit)
                {
                    case 0: Console.Write("and ");
                        break;
                    case 1:
                        {
                            switch (thirdDigit)
                            {
                                case 0: Console.WriteLine("and ten");
                                    break;
                                case 1: Console.WriteLine("and eleven");
                                    break;
                                case 2: Console.WriteLine("and twelve");
                                    break;
                                case 3: Console.WriteLine("and thirteen");
                                    break;
                                case 4: Console.WriteLine("and fourteen");
                                    break;
                                case 5: Console.WriteLine("and fifteen");
                                    break;
                                case 6: Console.WriteLine("and sixteen");
                                    break;
                                case 7: Console.WriteLine("and seventeen");
                                    break;
                                case 8: Console.WriteLine("and eighteen");
                                    break;
                                case 9: Console.WriteLine("and nineteen");
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case 2: Console.Write("and twenty ");
                        break;
                    case 3: Console.Write("and thirty ");
                        break;
                    case 4: Console.Write("and fourty ");
                        break;
                    case 5: Console.Write("and fifthy ");
                        break;
                    case 6: Console.Write("and sixty ");
                        break;
                    case 7: Console.Write("and seventy ");
                        break;
                    case 8: Console.Write("and eighty ");
                        break;
                    case 9: Console.Write("and ninety ");
                        break;
                    default:
                        break;
                }

                if (secondDigit != 1)
                {
                    switch (thirdDigit)
                    {
                        case 1: Console.WriteLine("one");
                            break;
                        case 2: Console.WriteLine("two");
                            break;
                        case 3: Console.WriteLine("three");
                            break;
                        case 4: Console.WriteLine("four");
                            break;
                        case 5: Console.WriteLine("five");
                            break;
                        case 6: Console.WriteLine("six");
                            break;
                        case 7: Console.WriteLine("seven");
                            break;
                        case 8: Console.WriteLine("eight");
                            break;
                        case 9: Console.WriteLine("nine");
                            break;
                        default: Console.WriteLine("");
                            break;
                    }
                }
            }
            else if ((number >= 21) && (number <= 99))
            {
                firstDigit = (ushort)(number / 10);
                secondDigit = (ushort)(number % 10);
                switch (firstDigit)
                {
                    case 2: Console.Write("Twenty ");
                        break;
                    case 3: Console.Write("Thirty ");
                        break;
                    case 4: Console.Write("Fourty ");
                        break;
                    case 5: Console.Write("Fifty ");
                        break;
                    case 6: Console.Write("Sixty ");
                        break;
                    case 7: Console.Write("Seventy ");
                        break;
                    case 8: Console.Write("Eighty ");
                        break;
                    case 9: Console.Write("Ninety ");
                        break;
                    default:
                        break;
                }

                switch (secondDigit)
                {
                    case 1: Console.WriteLine("one");
                        break;
                    case 2: Console.WriteLine("two");
                        break;
                    case 3: Console.WriteLine("three");
                        break;
                    case 4: Console.WriteLine("four");
                        break;
                    case 5: Console.WriteLine("five");
                        break;
                    case 6: Console.WriteLine("six");
                        break;
                    case 7: Console.WriteLine("seven");
                        break;
                    case 8: Console.WriteLine("eight");
                        break;
                    case 9: Console.WriteLine("nine");
                        break;
                    default:
                        break;
                }
            }
            else if ((number >= 0) && (number <= 20))
            {
                switch (number)
                {
                    case 0: Console.WriteLine("Zero");
                        break;
                    case 1: Console.WriteLine("One");
                        break;
                    case 2: Console.WriteLine("Two");
                        break;
                    case 3: Console.WriteLine("Three");
                        break;
                    case 4: Console.WriteLine("Four");
                        break;
                    case 5: Console.WriteLine("Five");
                        break;
                    case 6: Console.WriteLine("Six");
                        break;
                    case 7: Console.WriteLine("Seven");
                        break;
                    case 8: Console.WriteLine("Eight");
                        break;
                    case 9: Console.WriteLine("Nine");
                        break;
                    case 10: Console.WriteLine("Ten");
                        break;
                    case 11: Console.WriteLine("Eleven");
                        break;
                    case 12: Console.WriteLine("Twelve");
                        break;
                    case 13: Console.WriteLine("Thirteen");
                        break;
                    case 14: Console.WriteLine("Fourteen");
                        break;
                    case 15: Console.WriteLine("Fifteen");
                        break;
                    case 16: Console.WriteLine("Sixteen");
                        break;
                    case 17: Console.WriteLine("Seventeen");
                        break;
                    case 18: Console.WriteLine("Eighteen");
                        break;
                    case 19: Console.WriteLine("Nineteen");
                        break;
                    case 20: Console.WriteLine("Twenty");
                        break;
                    default:
                        break;
                }
                
            }
        }
   }
