//Task 10
//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
using System;
    class EmployeeData
    {
        static void Main()
        {
            Console.WriteLine("Your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Your age:");
            byte age;
            bool incorrectAge = byte.TryParse(Console.ReadLine(), out age);
            while ((!incorrectAge) || (age <= 0) || (age > 100))
            {
                Console.WriteLine("Incorrect age.\nPlease try again: ");
                incorrectAge = byte.TryParse(Console.ReadLine(), out age);
            }

            Console.WriteLine("Your Gender: ");
            char gender;
            bool incorrectSex = char.TryParse(Console.ReadLine(), out gender);
            while ((!incorrectSex) || ((gender != 'f') && (gender != 'm')))
            {
                Console.WriteLine("Incorrect gender.\nPlease enter \"f\" or \"m\": ");
                incorrectSex = char.TryParse(Console.ReadLine(), out gender);
            }

            Console.WriteLine("Your ID Number: ");
            long idNumber;
            bool incorrectID = long.TryParse(Console.ReadLine(), out idNumber);
            while ((!incorrectID) || (idNumber < 1000000000) || (idNumber > 9999999999))
            {
                Console.WriteLine("Incorrect ID Number.\nTry again: ");
                incorrectID = long.TryParse(Console.ReadLine(), out idNumber);
            }

            Console.WriteLine("Your Employee Number: ");
            int employeeNumber;
            bool incorrectNumber = int.TryParse(Console.ReadLine(), out employeeNumber);
            while ((!incorrectNumber) || (employeeNumber < 27560000) || (employeeNumber > 27569999))
                {
                    Console.WriteLine("Incorrect Employee Number.\nPlease try again: ");
                    incorrectNumber = int.TryParse(Console.ReadLine(), out employeeNumber);
                }

            Console.WriteLine();
            Console.WriteLine("First Name: {0}\nLast Name: {1}\nAge: {2}\nGender: {3}\nID number: {4}\nEmployee Number: {5}", firstName, lastName, age, gender, idNumber, employeeNumber);
        }
    }
