////Task Description is in its respected file in same project
namespace ExamCSharp2Task2 
{
    using System;
    using System.Text;

    public class MathProblem
    {
        //// this is set up in task description
        private const int NumericSystem = 19;

        private static void Main()
        {
            string inputText = Console.ReadLine();
            string[] splited = inputText.Split(' ');
            long decimalSum = 0;
            StringBuilder codePart = new StringBuilder();
            string word;

            //// translate from alien lenguage to decimal numeric system
            for (int i = 0; i < splited.Length; i++)
            {
                word = splited[i];
                for (int symbol = 0; symbol < word.Length; symbol++)
                {
                    codePart.Append(TranslateFromAlien(word[symbol]));
                }

                decimalSum += ConvertToDecimalAlgorithm(codePart);
                codePart.Clear();
            }

            ////Convert from decimal to 19 numeric system and translate it to Alien
            string strangeNumeralSum = ConvertFromDecimalAlgorithm(decimalSum, NumericSystem);
            for (int i = 0; i < strangeNumeralSum.Length; i++)
            {
                codePart.Append(TranslateToAlien(strangeNumeralSum[i]));
            }

            Console.WriteLine("{0} = {1}", codePart, decimalSum);
        }

        private static string TranslateFromAlien(char input)
        {
            string number = null;
            switch (input.ToString())
            {
                case "a": number = "0";
                    break;
                case "b": number = "1";
                    break;
                case "c": number = "2";
                    break;
                case "d": number = "3";
                    break;
                case "e": number = "4";
                    break;
                case "f": number = "5";
                    break;
                case "g": number = "6";
                    break;
                case "h": number = "7";
                    break;
                case "i": number = "8";
                    break;
                case "j": number = "9";
                    break;
                case "k": number = "A";
                    break;
                case "l": number = "B";
                    break;
                case "m": number = "C";
                    break;
                case "n": number = "D";
                    break;
                case "o": number = "E";
                    break;
                case "p": number = "F";
                    break;
                case "q": number = "G";
                    break;
                case "r": number = "H";
                    break;
                case "s": number = "I";
                    break;
            }

            return number;
        }

        private static long ConvertToDecimalAlgorithm(StringBuilder number)
        {
            long result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                switch (number[i])
                {
                    case 'A': result = result + ((long)Math.Pow(19, number.Length - 1 - i) * 10);
                        break;
                    case 'B': result = result + ((long)Math.Pow(19, number.Length - 1 - i) * 11);
                        break;                                                                 
                    case 'C': result = result + ((long)Math.Pow(19, number.Length - 1 - i) * 12);
                        break;                                                                 
                    case 'D': result = result + ((long)Math.Pow(19, number.Length - 1 - i) * 13);
                        break;                                                                 
                    case 'E': result = result + ((long)Math.Pow(19, number.Length - 1 - i) * 14);
                        break;                                                                 
                    case 'F': result = result + ((long)Math.Pow(19, number.Length - 1 - i) * 15);
                        break;                                                                 
                    case 'G': result = result + ((long)Math.Pow(19, number.Length - 1 - i) * 16);
                        break;                                                                 
                    case 'H': result = result + ((long)Math.Pow(19, number.Length - 1 - i) * 17);
                        break;                                                                 
                    case 'I': result = result + ((long)Math.Pow(19, number.Length - 1 - i) * 18);
                        break;                                                                 
                    case '0': result = result + ((long)Math.Pow(19, number.Length - 1 - i) * 0);
                        break;                                                                 
                    case '1': result = result + ((long)Math.Pow(19, number.Length - 1 - i) * 1);
                        break;                                                                 
                    case '2': result = result + ((long)Math.Pow(19, number.Length - 1 - i) * 2);
                        break;                                                                 
                    case '3': result = result + ((long)Math.Pow(19, number.Length - 1 - i) * 3);
                        break;                                                                 
                    case '4': result = result + ((long)Math.Pow(19, number.Length - 1 - i) * 4);
                        break;                                                                 
                    case '5': result = result + ((long)Math.Pow(19, number.Length - 1 - i) * 5);
                        break;                                                                  
                    case '6': result = result + ((long)Math.Pow(19, number.Length - 1 - i) * 6);
                        break;                                                                  
                    case '7': result = result + ((long)Math.Pow(19, number.Length - 1 - i) * 7);
                        break;                                                                   
                    case '8': result = result + ((long)Math.Pow(19, number.Length - 1 - i) * 8);
                        break;
                    case '9': result = result + ((long)Math.Pow(19, number.Length - 1 - i) * 9);
                        break;                                                                   
                }                                                                                
            }                                                                                    

            return result;
        }

        private static string ConvertFromDecimalAlgorithm(long number, int numericSystem)
        {
            string result = null;

            if (number == 0)
            {
                result = "0";
            }

            while (number > 0)
            {
                switch (number % numericSystem)
                {
                    case 0: result = "0" + result;
                        break;
                    case 1: result = "1" + result;
                        break;
                    case 2: result = "2" + result;
                        break;
                    case 3: result = "3" + result;
                        break;
                    case 4: result = "4" + result;
                        break;
                    case 5: result = "5" + result;
                        break;
                    case 6: result = "6" + result;
                        break;
                    case 7: result = "7" + result;
                        break;
                    case 8: result = "8" + result;
                        break;
                    case 9: result = "9" + result;
                        break;
                    case 10: result = "A" + result;
                        break;
                    case 11: result = "B" + result;
                        break;
                    case 12: result = "C" + result;
                        break;
                    case 13: result = "D" + result;
                        break;
                    case 14: result = "E" + result;
                        break;
                    case 15: result = "F" + result;
                        break;
                    case 16: result = "G" + result;
                        break;
                    case 17: result = "H" + result;
                        break;
                    case 18: result = "I" + result;
                        break;
                }

                number /= numericSystem;
            }

            return result;
        }

        private static string TranslateToAlien(char input)
        {
            string number = null;
            switch (input)
            {
                case '0': number = "a";
                    break;
                case '1': number = "b";
                    break;
                case '2': number = "c";
                    break;
                case '3': number = "d";
                    break;
                case '4': number = "e";
                    break;
                case '5': number = "f";
                    break;
                case '6': number = "g";
                    break;
                case '7': number = "h";
                    break;
                case '8': number = "i";
                    break;
                case '9': number = "j";
                    break;
                case 'A': number = "k";
                    break;
                case 'B': number = "l";
                    break;
                case 'C': number = "m";
                    break;
                case 'D': number = "n";
                    break;
                case 'E': number = "o";
                    break;
                case 'F': number = "p";
                    break;
                case 'G': number = "q";
                    break;
                case 'H': number = "r";
                    break;
                case 'I': number = "s";
                    break;
            }

            return number;
        }
    }
}