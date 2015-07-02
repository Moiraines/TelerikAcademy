//Task 2
//Define abstract class Human with a first name and a last name. Define a new class Student which is derived from Human and has a new field – grade. Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay and a method MoneyPerHour() that returns money earned per hour by the worker. Define the proper constructors and properties for this hierarchy.
//Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
//Initialize a list of 10 workers and sort them by money per hour in descending order.
//Merge the lists and sort them by first name and last name.

namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StudentsAndWorkersMain
    {
        static void Main()
        {

            //Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
            var students = new List<Student>
            {
                new Student("Nikolay", "Kostov", 6),
                new Student("Evlogi", "Hristov", 4),
                new Student("Ivaylo", "Kenov", 5.90),
                new Student("Doncho", "Minkov", 5.20),
                new Student("Svetla", "Svetlova", 4.50),
                new Student("Ivan", "Kornishonkov", 3.5),
                new Student("Pesho", "Peshov", 3.20),
                new Student("Gosho", "Goshov", 3.90),
                new Student("Garabei", "Garabeev", 2),
                new Student("Svetlin", "Nakov", 5.67),
            };

            var orderedStudents = students.OrderBy(x => x.Grade);

            Console.WriteLine("Ordered by grades students: \n");
            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " Grade: " + student.Grade);
            }

            //Initialize a list of 10 workers and sort them by money per hour in descending order.
            var workers = new List<Worker>
            {
                new Worker("Mitko", "Palauzov", 100, 10),
                new Worker("Kalitko", "Uzov", 80, 8),
                new Worker("Boyko", "Borisov", 3170.25M, 5),
                new Worker("Tsvetana", "Pironkova", 500, 8),
                new Worker("Vavilon", "Tetevenski", 280.45M, 8),
                new Worker("Konevruz", "Uzdov", 1000, 8),
                new Worker("Kilimqv", "Kalimqvkov", 100, 10),
                new Worker("Baba", "Minkovica", 100, 9),
                new Worker("Mincho", "Praznikov", 280.45M, 6),
                new Worker("Baba", "Chistachkova", 60, 4),
            };

            var orderedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());
            
            Console.WriteLine("\nOrdered by money per hour in descending order: \n");
            foreach (var worker in orderedWorkers)
            {
                Console.WriteLine(worker.FirstName + " " + worker.LastName + " Earned money per hour: " + worker.MoneyPerHour());
            }

            //Merge the lists and sort them by first name and last name.

            var merged = students.Concat<Human>(workers).OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            Console.WriteLine("\nMerged groups ordered by first name, then by last name: \n");
            foreach (var human in merged)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            }

        }
    }
}
