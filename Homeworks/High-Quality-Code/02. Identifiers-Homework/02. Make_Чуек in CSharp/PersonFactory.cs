namespace PersonFactory
{
    public class PersonFactory
    {
        public void Create(int age)
        {
            Person person = new Person();
            person.Age = age;
            if (age % 2 == 0)
            {
                person.Name = "Handsome";
                person.Gender = Gender.Male;
            }
            else
            {
                person.Name = "Charming";
                person.Gender = Gender.Female;
            }
        }
    }
}
