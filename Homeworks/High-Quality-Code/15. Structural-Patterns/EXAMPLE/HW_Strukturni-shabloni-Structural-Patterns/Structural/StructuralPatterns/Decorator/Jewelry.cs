namespace Decorator
{
    using System;

    internal class Jewelry : Outfit
    {
        private readonly string brand;
        private readonly string type;
        private readonly string manufacturerCountry;

        public Jewelry(string brand, string type, string manufacturerCountry, int itemsCount)
        {
            this.brand = brand;
            this.type = type;
            this.manufacturerCountry = manufacturerCountry;
            this.ItemsCount = itemsCount;
        }

        public override void Wearing()
        {
            Console.WriteLine("-------------The woman wears Jewelry----------- ");
            Console.WriteLine("Brand: {0}", this.brand);
            Console.WriteLine("Type: {0}", this.type);
            Console.WriteLine("Manufacturer Country: {0}", this.manufacturerCountry);
            Console.WriteLine(" # Items: {0}", this.ItemsCount);
        }
    }
}
