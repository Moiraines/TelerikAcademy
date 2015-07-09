////Task Description is in its respected file in same project
namespace ExamCSharp1Task2
{
    using System;
    using System.Numerics;

    public class TextTransformer
    {
        public const int LowerLetterPositionCoeficient = 97;
        public const int UpperLetterPositionCoeficient = 65;

        public static void Main()
        {
            int moduleDivider = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            ////declare BigInteger due the results may go wacky
            BigInteger result = 0;

            result = Converter(result, text, moduleDivider);

            Console.WriteLine(result);
        }

        /// <summary>
        /// Convert logic of the text to number
        /// </summary>
        /// <param name="result">input store parameter for the result we searching for</param>
        /// <param name="text"> inputed text from the console</param>
        /// <param name="moduleDivider">the input paramater used for module divider</param>
        /// <returns>returns the result from text convertion</returns>
        public static BigInteger Converter(BigInteger result, string text, int moduleDivider)
        {
            for (int index = 0; index < text.Length; index++)
            {
                char symbol = text[index];

                if (char.IsDigit(symbol))
                {
                    result *= symbol - '0';
                }
                else if ('a' <= symbol && symbol <= 'z')
                {
                    result += LetterPositionSet(LowerLetterPositionCoeficient, symbol);
                }
                else if ('A' <= symbol && symbol <= 'Z')
                {
                    result += LetterPositionSet(UpperLetterPositionCoeficient, symbol);
                }
                else if (symbol == '@')
                {
                    break;
                }
                else
                {
                    result %= moduleDivider;
                }
            }   

            return result;
        }

        public static int LetterPositionSet(int positionCoeficient, char symbol)
        {
            int letterPosition = symbol - positionCoeficient;

            return letterPosition;
        }
    }
}