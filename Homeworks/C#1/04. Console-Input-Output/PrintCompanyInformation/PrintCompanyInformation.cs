//Task 2
//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.
using System;

namespace PrintCompanyInformation
{
    class PrintCompanyInformation
    {
        static void Main()
        {

            //Dont input country code and town code for the phone number, and country code for the cell number! Enter only the phone number and the operator code for cell phone
            ulong phoneNumber;
            ulong managerPhone;
            int faxNumber;
            byte managerAge;
            Console.WriteLine("Please, enter your company name: ");
            string companyName = Console.ReadLine();

            Console.WriteLine("please, enter your company address: ");
            string companyAddress = Console.ReadLine();

            Console.WriteLine("Please, enter cell phone number");
            bool correctNumber = ulong.TryParse(Console.ReadLine(), out phoneNumber);
            while (!correctNumber)
                {
                    Console.WriteLine("Wrong number format.\nTry again: ");
                    correctNumber = ulong.TryParse(Console.ReadLine(), out phoneNumber);
                }

            Console.WriteLine("Enter Fax number: ");
            correctNumber = int.TryParse(Console.ReadLine(), out faxNumber);
            while (!correctNumber)
                {
                    Console.WriteLine("Wrong number format.\nTry again: ");
                    correctNumber = int.TryParse(Console.ReadLine(), out faxNumber);
                }

            Console.WriteLine("Enter company web site: ");
            string webSite = Console.ReadLine();

            Console.WriteLine("Manager first name: ");
            string manFirstName = Console.ReadLine();

            Console.WriteLine("Manager last name: ");
            string manLastName = Console.ReadLine();

            Console.WriteLine("Enter age: ");
            correctNumber = byte.TryParse(Console.ReadLine(), out managerAge);
            while (!correctNumber || managerAge < 0 || managerAge >= 150)
                {
                    Console.WriteLine("Wrong number format.\nTry again: ");
                    correctNumber = byte.TryParse(Console.ReadLine(), out managerAge);
                }

            Console.WriteLine("Please, enter phone number");
            correctNumber = ulong.TryParse(Console.ReadLine(), out managerPhone);
            while (!correctNumber || managerAge < 0 || managerAge >= 150)
                {   
                    Console.WriteLine("Wrong number format.\nTry again: ");
                    correctNumber = ulong.TryParse(Console.ReadLine(), out managerPhone);
                }

            Console.WriteLine();
            Console.WriteLine("{0}\nAdress: {1}\nTel. +359 {2:### ## ## ###}\nFax: {3}\nWeb Site: {4}", companyName, companyAddress, phoneNumber, faxNumber, webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. +359 02 {3:### ###})", manFirstName, manLastName, managerAge, managerPhone);
        }
    }
}
