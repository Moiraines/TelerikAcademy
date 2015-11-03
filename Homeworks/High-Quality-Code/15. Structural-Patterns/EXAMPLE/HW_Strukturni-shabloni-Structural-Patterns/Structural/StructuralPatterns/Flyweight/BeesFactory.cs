namespace Flyweight
{
    using System.Collections.Generic;

    public class BeesFactory
    {
        private readonly Dictionary<string, Bee> bees = new Dictionary<string, Bee>();

        public Bee GetBee(string key)
        {
            Bee bee = null;
            if (this.bees.ContainsKey(key))
            {
                bee = this.bees[key];
            }
            else
            {
                switch (key)
                {
                    case "scout":
                        bee = new BeesScouts();
                        break;
                    case "queen":
                        bee = new QueenBee();
                        break;
                    case "collector":
                        bee = new BeesColectors();
                        break;
                }

                this.bees.Add(key, bee);
            }

            return bee;
        }
    }
}
