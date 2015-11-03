namespace Decorator
{
    using System;

    public static class Woman
    {
        public static void Main()
        {
            var bracelet = new Jewelry("Tiffany", "bracelet", "America", 10);
            bracelet.Wearing();
            Console.WriteLine(" ");

            var shirt = new Wear(7, "shirt", "Guess", "America", 3);
            shirt.Wearing();
            Console.WriteLine(" ");

            Console.WriteLine("Dress up the bracelent");
            var dressUpBracelet = new DressUp(bracelet, 5);
            dressUpBracelet.Wearing();
            Console.WriteLine(" ");

            Console.WriteLine("Dress up the shirt");
            var dressUpShirt = new DressUp(shirt, 1);
            dressUpShirt.Wearing();
            Console.WriteLine(" ");
        }
    }
}
