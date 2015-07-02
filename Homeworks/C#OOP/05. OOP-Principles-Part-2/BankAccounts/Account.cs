namespace BankAccounts
{
    using System;
    public abstract class Account : IDepositable
    {
        //fields
        private decimal balance;
        private decimal interestRate;

        //constructor
        public Account(decimal balance, decimal interestRate, Customer customer)
        {
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.Customer = customer;
        }

        //properties
        public decimal Balance 
        {
            get { return this.balance; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance can not be negative number");
                }
                this.balance = value;
            } 
        }

        public decimal InterestRate 
        {
            get { return this.interestRate; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest Rate can not be negative number");
                }
                this.interestRate = value;
            }
        }

        public Customer Customer { get; private set; }


        //abstract method for Deposit transactions
        public abstract void DepositTrans(decimal amount);

        //calculate interest method
        public virtual decimal Interest(int months)
        {
            if (months <= 0 )
            {
                throw new ArgumentOutOfRangeException("Months can not be negative!");
            }
            decimal interest = this.Balance * (this.InterestRate / 100) * months;

            return interest;
        }
    }
}
