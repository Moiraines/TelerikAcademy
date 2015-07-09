////Its not finished!
////Task Description is in its respected file in same project
namespace ExamCSharp1Task5 
{
    using System;

    public class SequenceDetector
    {
        public static void Main()
        {
            string concatenator = null;
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                uint number = uint.Parse(Console.ReadLine());
                concatenator = concatenator + Convert.ToString(number, 2).PadLeft(30, '0');
            }

            ulong oneSequenceMaxlength = 0;
            ulong zeroSequenceMaxlength = 0;
            ulong zeroCurrentCounter = 0;
            ulong oneCurrentCounter = 0;

            for (int i = 0; i <= concatenator.Length - 1; i++)
            {
                if (concatenator[i] == '0')
                {
                    if (i > 0 && concatenator[i - 1] == '1')
                    {
                        if (zeroCurrentCounter > zeroSequenceMaxlength)
                        {
                            zeroSequenceMaxlength = zeroCurrentCounter;
                        }

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
                    if (i > 0 && concatenator[i - 1] == '0')
                    {
                        if (oneCurrentCounter > oneSequenceMaxlength)
                        {
                            oneSequenceMaxlength = oneCurrentCounter;
                        }

                        oneCurrentCounter = 0;
                        oneCurrentCounter++;
                    }
                    else
                    {
                        oneCurrentCounter++;
                    }
                }
            }

            if (zeroCurrentCounter > zeroSequenceMaxlength)
            {
                zeroSequenceMaxlength = zeroCurrentCounter;
            }

            if (oneCurrentCounter > oneSequenceMaxlength)
            {
                oneSequenceMaxlength = oneCurrentCounter;
            }

            Console.WriteLine(zeroSequenceMaxlength);
            Console.WriteLine(oneSequenceMaxlength);
        }
    }
}