namespace BankAccounts
{
    using System;
    public class Mortgage : Account
    {
        public Mortgage(decimal balance, decimal interestRate, Customer customer) 
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

        public override decimal Interest(int months)
        {
            if (this.Customer is Company)
            {
                if (months <= 12 && months > 0)
                {
                    return (base.Interest(months) / 2);
                }
                else
                {
                    return base.Interest(months - 12);
                }
            }
            else
            {
                if (months <= 6 && months > 0)
                {
                    return 0.0M;
                }
                else
                {
                    return base.Interest(months - 6);
                }
            }
        }
    }
}
