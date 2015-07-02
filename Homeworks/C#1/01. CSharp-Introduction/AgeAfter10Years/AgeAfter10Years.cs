//Task 15
//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
using System;
class AgeAfter10Years
{
    static void Main()
    {
        DateTime currentDate = DateTime.Now;
        Console.WriteLine("Моля въведете рожденната си дата в MM/DD/YYYY формат: ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());
        int age = currentDate.Year-birthDate.Year;
        if (birthDate.Month > currentDate.Month)
        {
            age = age - 1;
        }
        else if (birthDate.Month == currentDate.Month)
             {
                if (birthDate.Day > currentDate.Day)
                {
                    age = age - 1;
                }
             }
        Console.WriteLine("Вие сте на {0} години", (age));
        Console.WriteLine("След десетилетие ще бъдете на {0} години", ((age)+10));
    }
}