namespace BankAccounts
{
    using System;
    public abstract class Customer
    {
        private string name;
        private int clientNumber;
        private string adress;

        public Customer(string name, int clientNumber, string adress)
        {
            this.Name = name;
            this.ClientNumber = clientNumber;
            this.Adress = adress;
        }

        public string Name 
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2)
                {
                    throw new ArgumentException("Name should be more then 1 symbol");
                }
                this.name = value;
            }
        }

        public int ClientNumber 
        {
            get { return this.clientNumber; }
            private set
            {
                if (value < 100000000 && value > 999999999)
                {
                    throw new ArgumentException("Invalid Client Number");
                }
                this.clientNumber = value;
            }
        }

        public string Adress 
        {
            get { return this.adress; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2)
                {
                    throw new ArgumentException("Adress should be more then 1 symbol");
                }
                this.adress = value;
            }
        }
    }
}
