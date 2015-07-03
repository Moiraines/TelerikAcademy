namespace Chef
{
    using System;

    public class Chef
    {
        public void Cook()
        {
            Bowl bowl = this.GetBowl();
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();

            this.Peel(potato);
            this.Peel(carrot);

            this.Cut(potato);
            this.Cut(carrot);

            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Bowl GetBowl()
        {
            throw new NotImplementedException("TODO");
        }

        private Carrot GetCarrot()
        {
            throw new NotImplementedException("TODO");
        }

        private Potato GetPotato()
        {
            throw new NotImplementedException("TODO");
        }

        private void Peel(Vegetable potato)
        {
            ////...
        }

        private void Cut(Vegetable vegetable)
        {
            ////...
        }
    }
}
