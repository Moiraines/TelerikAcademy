//Task 9 - 16

namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StudentsMain
    {

        //Creating a list of sample students - Task 9
        public static Student sampleStudent1 = new Student(
        "Nikolay", "Kostov", "000114", "02200300", "niki@abv.bg",
        new List<int>
                {
                    (int)PossibleMarks.Average, 
                    (int)PossibleMarks.Very_good, 
                    (int)PossibleMarks.Poor, 
                    (int)PossibleMarks.Excellent
                },
            2);

        public static Student sampleStudent2 = new Student(
        "Ivaylo", "Kenov", "000206", "0888200300", "ivo@abv.bg",
        new List<int>
                {
                    (int)PossibleMarks.Good, 
                    (int)PossibleMarks.Poor, 
                    (int)PossibleMarks.Poor, 
                    (int)PossibleMarks.Average
                }
        , 1);

        public static Student sampleStudent3 = new Student(
        "Doncho", "Minkov", "000306", "+35928200300", "doncho@mail.bg",
        new List<int>
                {
                    (int)PossibleMarks.Good, 
                    (int)PossibleMarks.Excellent, 
                    (int)PossibleMarks.Very_good, 
                    (int)PossibleMarks.Average
                }
        , 2);

        public static Student sampleStudent4 = new Student(
        "Evlogi", "Hristov", "000310", "+359886200300", "evlogi@yahoo.com",
        new List<int>
                {
                    (int)PossibleMarks.Good, 
                    (int)PossibleMarks.Poor, 
                    (int)PossibleMarks.Very_good, 
                    (int)PossibleMarks.Average
                }
        , 1);

        public static List<Student> sampleStudents = new List<Student> { sampleStudent1, sampleStudent2, sampleStudent3, sampleStudent4 };
        static void Main()
        {
            

            //Select only the students from group 2 - Task 9

            var studentsFromGroup2 =
                from student in sampleStudents
                where student.GroupNumber == 2
                select student;

            // Order the students from group 2 by first name

            var orderedStudentsFromGroup2 =
                from student in studentsFromGroup2
                orderby student.FirstName
                select student;

            Console.WriteLine("Students from group 2, ordered by first name (using LINQ):\n");
            foreach (Student student in orderedStudentsFromGroup2)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }


            //implement the same as above, using extension methods - Task 10
            var orderedStudents2 = sampleStudents.Where(x => x.GroupNumber == 2).OrderBy(x => x.FirstName);

            Console.WriteLine("Students from group 2, ordered by first name (using Extension methods):\n");
            foreach (Student student in orderedStudentsFromGroup2)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }


            //Extract all students that have email in abv.bg. - Task 11

            var abvMailStudents =
                from student in sampleStudents
                where student.Email.Contains("@abv.bg")
                select student;

            Console.WriteLine("Students with email in abv.bg:\n");

            foreach (Student student in abvMailStudents)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }

            //Extract all students with phones in Sofia - Task 12

            var sofiaPhonesStudents =
                from student in sampleStudents
                where student.Tel.StartsWith("02") || student.Tel.StartsWith("3592")
                select student;

            Console.WriteLine("Students with phones in Sofia:\n");

            foreach (Student student in sofiaPhonesStudents)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }

            //Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks. - Task 13

            var excellentStudents =
                from student in sampleStudents
                where student.Marks.Contains(6)
                select new 
                {
                    FullName = student.FirstName + " " + student.LastName,
                    MarksList = student.Marks
                };

            Console.WriteLine("Students with at least one mark Excellent in Sofia:\n");

            foreach (var student in excellentStudents)
            {
                Console.WriteLine("Full name: {0}", student.FullName);
                Console.WriteLine("Marks: {0}", string.Join(", ", student.MarksList));
                Console.WriteLine();
            }

            //Extract students with two marks - Task 14

            var studentsWithTwoPoorMarks = sampleStudents.Where(x => x.Marks.FindAll(y => y == 2).Count == 2).
                Select(x => new {
                    FullName = x.FirstName + " " + x.LastName,
                    MarksList = x.Marks    
                });

            Console.WriteLine("Students with at exactly two marks Poor in Sofia:\n");

            foreach (var student in studentsWithTwoPoorMarks)
            {
                Console.WriteLine("Full name: {0}", student.FullName);
                Console.WriteLine("Marks: {0}", string.Join(", ", student.MarksList));
                Console.WriteLine();
            }

            //Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN). - Task 15

            var students2006 = sampleStudents.Where(x => x.FN[4] == '0' && x.FN[5] == '6');
            var allMarks2006 = new List<int>();

            foreach (var student in students2006)
            {
                allMarks2006.AddRange(student.Marks);
            }

            Console.WriteLine("All marks of the students, enrolled in 2006:\n{0}", string.Join(", ", allMarks2006));
            Console.WriteLine();

            //Groups - Task 16

            Group group1 = new Group(1, "Mathematics");
            Group group2 = new Group(2, "Literature");
            Group group3 = new Group(3, "Computer Science");

            List<Group> groups = new List<Group> { group1, group2, group3 };

            var groupsMathematics =
                from someGroup in groups
                where someGroup.GroupNumber == 1
                join student in sampleStudents on someGroup.GroupNumber equals student.GroupNumber
                select new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    Department = someGroup.DepartmentName
                };

            Console.WriteLine("All students from mathematics department, extracted as new anonymous classes," +
                              " containing properties Name and Department:");

            foreach (var student in groupsMathematics)
            {
                Console.WriteLine(student);
            }

            //Create a program that extracts all students grouped by GroupNumber and then prints them to the console. - Task 18

            sampleStudents.Add(new Student("Ivan", "Ivanov", "001212", "0878121212", "vankata@gmail.com",
                   new List<int> { (int)PossibleMarks.Good, (int)PossibleMarks.Very_good, (int)PossibleMarks.Average }, 3));

            var groupedStudents =
                from student in sampleStudents
                group student by student.GroupNumber into groupss
                select new
                {
                    Group = groupss.Key,
                    Students = groupss.ToList()
                };

            foreach (var grouped in groupedStudents)
            {
                Console.WriteLine("\nGroup: {0} Students:\n---------------------\n{1}", grouped.Group,
                    string.Join("\r\n\r\n", grouped.Students));
            }

            //Rewrite the previous using extension methods. - Task 19

            var groupedStudents2 = sampleStudents.GroupBy(x => x.GroupNumber,
               (groupNumber, students) => new { Group = groupNumber, Students = students });
            //its the same
            //foreach (var grouped in groupedStudents2)
            //{
            //    Console.WriteLine("\nGroup: {0} Students:\n---------------------\n{1}", grouped.Group,
            //        string.Join("\r\n\r\n", grouped.Students));
            //}
               
        }
    }
}
