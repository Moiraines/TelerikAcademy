namespace Decorator
{
    using System;

    internal class Wear : Outfit
    {
        private readonly int size;
        private readonly string brand;
        private readonly string type;
        private readonly string manufacturerCountry;

        public Wear(int size, string brand, string type, string manufacturerCountry, int itemsCount)
        {
            this.size = size;
            this.brand = brand;
            this.type = type;
            this.manufacturerCountry = manufacturerCountry;
            this.ItemsCount = itemsCount;
        }

        public override void Wearing()
        {
            Console.WriteLine("-------------The woman Wears----------- ");
            Console.WriteLine("Type: {0}", this.type);
            Console.WriteLine("Brand: {0}", this.brand);
            Console.WriteLine("Size: {0}", this.size);
            Console.WriteLine("Manufacturer Country: {0}", this.manufacturerCountry);
            Console.WriteLine(" # Items: {0}", this.ItemsCount);
        }
    }
}
