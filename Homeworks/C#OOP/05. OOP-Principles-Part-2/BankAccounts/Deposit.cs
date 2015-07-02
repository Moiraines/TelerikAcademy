namespace BankAccounts
{
    using System;
    public class Deposit : Account, IWithdrawable
    {
        public Deposit(decimal balance, decimal interestRate, Customer customer) 
            : base(balance, interestRate, customer)
        {
            
        }

        public override void DepositTrans(decimal amount)
        {
            if (amount < 0)
	        {
		        throw new ArgumentOutOfRangeException("You can't deposit negative amount");
	        }
            this.Balance += amount;
        }

        public void WithdrawTrans(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("The amount can not be negative");
            }
            if (amount > this.Balance)
            {
                throw new ArgumentOutOfRangeException("The balance cannot be negative");
            }
            this.Balance -= amount;
        }

        public override decimal Interest(int months)
        {
            if (this.Balance > 0 || this.Balance < 1000)
            {
                return 0.0M;
            }
            else
            {
                return base.Interest(months);
            }
        }
    }
}
