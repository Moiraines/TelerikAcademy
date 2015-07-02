//Task 1
//The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
using System;
    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.WriteLine("Please enter your weight: ");
            double earthWeight;
            bool incorrectWeight = double.TryParse(Console.ReadLine(), out earthWeight);
            double moonWeight = earthWeight * (17.0 / 100);
            while ((!incorrectWeight) || (earthWeight <= 0))
            {
                Console.WriteLine("Invalid weight value!\nPlease try again: ");
                incorrectWeight = double.TryParse(Console.ReadLine(), out earthWeight);
            }

            Console.WriteLine("Your weight on the moon would be: {0} ", moonWeight);
        }
    }
