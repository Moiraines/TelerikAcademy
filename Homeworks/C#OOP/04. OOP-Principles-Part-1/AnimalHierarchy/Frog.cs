namespace AnimalHierarchy
{
    public class Frog : Animal
    {
        public Frog(string name, byte age, Gender sex) : base(name, age, sex) 
        {
 
        }

        public override string MakeSound()
        {
            return string.Format("Ribit, ribit");
        }
    }
}
