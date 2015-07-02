//Task 3
//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
//Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class AnimalHierarchyMain
    {
        static void Main()
        {
            Animal[] animals =
            {
                new Dog("Pesho", 22, Gender.Male),
                new Dog("Gosho", 20, Gender.Female), 
                new Dog("Misho", 2, Gender.Female), 
                new Dog("Pisho", 10, Gender.Female), 
                new Frog("Balkan", 10, Gender.Male),
                new Frog("Doncho", 4, Gender.Male), 
                new Frog("Sharo", 10, Gender.Female), 
                new Frog("Vihur", 8, Gender.Male), 
                new Cat("Macorana", 3, Gender.Male),
                new Kitten("Doncho", 7), 
                new Tomcat("Sharo", 10), 
                new Tomcat("Vihur", 8), 
            };

            double averageDogsAge = animals.Where(x => x is Dog).Average(x => x.Age);
            double averageFrogsAge = animals.Where(x => x is Frog).Average(x => x.Age);
            double averageCatsAge = animals.Where(x => x is Cat).Average(x => x.Age);

            Console.WriteLine("Average age of the dogs: {0}", averageDogsAge);
            Console.WriteLine("Average age of the frogs: {0}", averageFrogsAge);
            Console.WriteLine("Average age of the cats: {0}", averageCatsAge);

            



        }
    }
}
