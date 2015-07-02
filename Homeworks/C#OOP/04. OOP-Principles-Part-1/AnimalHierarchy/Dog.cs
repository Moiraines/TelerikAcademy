namespace AnimalHierarchy
{
    public class Dog : Animal
    {
        public Dog(string name, byte age, Gender sex) : base(name, age, sex) 
        {
 
        }

        public override string MakeSound()
        {
            return string.Format("Bau, bau");
        }
        
    }
}
