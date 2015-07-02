namespace GSM
{
    using System;
    using System.Globalization;
    using System.Threading;
    using System.Collections.Generic;
    class GSMTest
    {
        static void Main()
        {
            GSMTests(); // Task 7

            //Task 12
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            GSMCallHistoryTest.CreateCallHistory();
            GSMCallHistoryTest.DisplayCallInfo();
            Console.WriteLine(new string('-', 50));
            GSMCallHistoryTest.CalculateAndPrintTestCallsPrice();
            GSMCallHistoryTest.RemoveLongestCall();
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("The Longest call has been removed.");
            GSMCallHistoryTest.CalculateAndPrintTestCallsPrice(); //Calculate and print test call price again 
            Console.WriteLine(new string('-', 50));
            GSMCallHistoryTest.testGSM.ClearHistory();
            Console.WriteLine("Call History list has been cleared");
            GSMCallHistoryTest.DisplayCallInfo(); //Display Call history again after clearing

        }


        //Task 7
        private static void GSMTests()
        {
            GSM test1 = new GSM("N95", "Nokia");
            GSM test2 = new GSM("Galaxy S3", "Samsung", 1200, "Az", new Battery(), new Display(), new List<Call>());
            GSM test3 = new GSM("Xperia", "Sony", 1300, "Az", new Battery("A64", 50, 60, BatteryType.LithiumIonPolymer), new Display(4.8M, 32000), new List<Call>());
            GSM[] gsms = { test1, test2, test3};
            foreach (var gsm in gsms)
            {
                Console.WriteLine(gsm);
                Console.WriteLine(new string('-', 50));
            }
            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
