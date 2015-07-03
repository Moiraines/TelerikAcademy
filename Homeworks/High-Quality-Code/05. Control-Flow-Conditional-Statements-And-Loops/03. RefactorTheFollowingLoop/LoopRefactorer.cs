namespace LoopRefactoring
{
    using System;

    public class LoopRefactorer
    {
        public static void Main()
        {
            ////initialize of the variables in the example to avoid compile erorrs
            string expectedValue = "It is time for Doncho to get back on track" +
                                   " and make a proper exam preparation!";
            var wisdoms = new string[10]; 

            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0 && wisdoms[i] == expectedValue)
                {
                    Console.WriteLine("Value Found");
                    break;
                }

                Console.WriteLine(wisdoms[i]);
            }

            // More code here
        }
    }
}
