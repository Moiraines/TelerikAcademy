//Task 1
//Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
//Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=

//Task 2
//Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.

//Task 3
//Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).
namespace StudentClass
{
    using System;
    class StudentClassMain
    {

        static void Main()
        {
            Student firstStudent = new Student("Ivan", "Doychinov", 3435467234, 2, Specialty.ApplingMath, University.TechnicalUniversity, Faculty.MathematicalFaculty);

            Student secondStudent = new Student("Petar", "Mihov", 3435467234, 2, Specialty.ApplingMath, University.TechnicalUniversity, Faculty.MathematicalFaculty);

            Student thirdStudent = new Student("Ivan", "Doychinov", 3435467234, 2, Specialty.ApplingMath, University.TechnicalUniversity, Faculty.MathematicalFaculty);

            if (firstStudent != secondStudent)  // it is true
                Console.WriteLine("{0} != {1}", firstStudent.FirstName, secondStudent.FirstName);

            if (firstStudent == thirdStudent)  // it is true
                Console.WriteLine("{0} == {1}", firstStudent.FirstName, thirdStudent.FirstName);

            Student deeplyCloned = (Student)firstStudent.Clone();


            Console.WriteLine("\nThe Cloned student is: ");
            Console.WriteLine(deeplyCloned);


            Console.WriteLine(firstStudent.CompareTo(secondStudent));

        }
    }
}
