
namespace GSM
{
    using System;
    using System.Globalization;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Linq;
    class GSMCallHistoryTest // Task 12
    {
        
        public static GSM testGSM = new GSM("N95", "Nokia");

        public static DateTime dateTestCall1 = DateTime.Parse("03/03/2015 19:15:30");
        public static DateTime dateTestCall2 = DateTime.Parse("09/03/2015 19:15:29");
        public static DateTime dateTestCall3 = DateTime.Parse("10/03/2015 23:15:30");
        public static DateTime dateTestCall4 = DateTime.Parse("11/03/2015 19:15:44");
        public static DateTime dateTestCall5 = DateTime.Parse("05/03/2015 05:15:30");
        public static DateTime dateTestCall6 = DateTime.Parse("12/03/2015 19:16:30");
        public static DateTime dateTestCall7 = DateTime.Parse("07/03/2015 13:15:00");

        public static Call[] testCalls = 
        {
            new Call(dateTestCall1, "0886445055", 160),
            new Call(dateTestCall1, "0886445055", 160),
            new Call(dateTestCall1, "0886145876", 220),
            new Call(dateTestCall1, "0898224567", 1080),
            new Call(dateTestCall1, "0886145876", 160),
            new Call(dateTestCall1, "0898224567", 340),
            new Call(dateTestCall1, "0886445055", 100)
        };

        public static void CreateCallHistory()
        {
            for (int i = 0; i < testCalls.Length; i++)
			{
			 testGSM.AddCalls(testCalls[i]);
			}
        }

        public static void DisplayCallInfo()
        {
            Console.WriteLine(testGSM.PrintCallHistory());
        }

        public static void CalculateAndPrintTestCallsPrice()
        {
            decimal price = testGSM.CalculateTotalPrice(0.37M);
            Console.WriteLine("Total price of test calls is: {0}", price);
        }

        public static void RemoveLongestCall()
        {
            Call longestCall = testGSM.CallHistory.OrderBy(x => x.Duration).ToArray()[testGSM.CallHistory.Count - 1];
            testGSM.DellCalls(longestCall);
        }
    }
}
