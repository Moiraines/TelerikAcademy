namespace Composite
{
    public static class MainClass
    {
        public static void Main()
        {
            var director = new SchoolMember("Ivanov", "director");

            var assistantDirector = new SchoolMember("Zlatkov", "assistant director");
            director.Add(assistantDirector);

            var mathTeacher = new SchoolMember("Petkova", "math teacher");
            assistantDirector.Add(mathTeacher);
            mathTeacher.Add(new Person("Ivancho", "student"));
            mathTeacher.Add(new Person("Mariika", "student"));
            mathTeacher.Add(new Person("Cvetancho", "student"));
            mathTeacher.Add(new Person("Ilianka", "student"));

            var biologyTeacher = new SchoolMember("Stoqnov", "biology teacher");
            assistantDirector.Add(biologyTeacher);
            biologyTeacher.Add(new Person("Misho ", "student"));
            biologyTeacher.Add(new Person("Vasko", "student"));
            biologyTeacher.Add(new Person("Polq", "student"));
            biologyTeacher.Add(new Person("Kalinka", "student"));
            biologyTeacher.Add(new Person("Maq", "student"));

            director.Display();
        }
    }
}
