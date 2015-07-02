//Task 4
//Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so.
//Write a program to test this functionality
namespace PersonClass
{
    using System;
    class PersonClassMain
    {
        static void Main()
        {
            Person pesho = new Person("Pesho", 20);
            Person gosho = new Person("Gosho");

            Console.WriteLine(pesho.ToString());
            Console.WriteLine(gosho.ToString());
        }
    }
}
