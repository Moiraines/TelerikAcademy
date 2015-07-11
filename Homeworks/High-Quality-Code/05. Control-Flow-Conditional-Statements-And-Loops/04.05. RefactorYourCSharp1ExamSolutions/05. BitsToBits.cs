////Its not finished!
////Task Description is in its respected file in same project
namespace ExamCSharp1Task5 
{
    using System;
    using System.Text;

    /// <summary>
    /// Get most right bit of every input number and concatenate them in one string.
    /// Then find the longest sequence of zeros and ones in it.
    /// </summary>
    public class SequenceDetector
    {
        public static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());
            StringBuilder numberSequence = new StringBuilder();

            numberSequence = ConcatenateNumbersBits(numbersCount, numberSequence);
   
            ulong zeroSequenceMaxlength = 0;
            ulong zeroCurrentCounter = 0;
            ulong oneSequenceMaxlength = 0;
            ulong oneCurrentCounter = 0;

            //// main logic for the sequence finder
            for (int symbol = 0; symbol <= numberSequence.Length - 1; symbol++)
            {
                if (numberSequence[symbol] == '0')
                {
                    if (symbol > 0 && numberSequence[symbol - 1] == '1')
                    {
                        zeroSequenceMaxlength = CheckForMaxSequence(zeroCurrentCounter, zeroSequenceMaxlength);
                        zeroCurrentCounter = 0;
                        zeroCurrentCounter++;
                    }
                    else
                    {
                        zeroCurrentCounter++;
                    }
                }
                else
                {
                    if (symbol > 0 && numberSequence[symbol - 1] == '0')
                    {
                        oneSequenceMaxlength = CheckForMaxSequence(oneCurrentCounter, oneSequenceMaxlength);

                        oneCurrentCounter = 0;
                        oneCurrentCounter++;
                    }
                    else
                    {
                        oneCurrentCounter++;
                    }
                }
            }

            //// check for the last number after loop is done
            zeroSequenceMaxlength = CheckForMaxSequence(zeroCurrentCounter, zeroSequenceMaxlength);
            oneSequenceMaxlength = CheckForMaxSequence(oneCurrentCounter, oneSequenceMaxlength);

            Console.WriteLine(zeroSequenceMaxlength);
            Console.WriteLine(oneSequenceMaxlength);
        }

        private static StringBuilder ConcatenateNumbersBits(int numbersCount, StringBuilder numberSequence)
        {
            for (int i = 1; i <= numbersCount; i++)
            {
                uint inputNumber = uint.Parse(Console.ReadLine());
                numberSequence.Append(Convert.ToString(inputNumber, 2).PadLeft(30, '0'));
            }
            
            return numberSequence;
        }

        private static ulong CheckForMaxSequence(ulong currentCounter, ulong sequenceMaxlength)
        {
            if (currentCounter > sequenceMaxlength)
            {
                sequenceMaxlength = currentCounter;
            }

            return sequenceMaxlength;
        }
    }
}