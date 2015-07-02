namespace AnimalHierarchy
{
    public class Cat : Animal
    {
        public Cat(string name, byte age, Gender sex) : base(name, age, sex) 
        {
 
        }

        public override string MakeSound()
        {
            return string.Format("Meow, meow");
        }
    }
}
