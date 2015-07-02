namespace BankAccounts
{
    using System;
    class Company : Customer
    {
        private string unifiedIdentityCode;

        public Company(string name, int clientNumber, string adress, string unifiedIdentityCode) 
            : base(name, clientNumber, adress)
        {
            this.UnifiedIdentityCode = unifiedIdentityCode;
        }

        public string UnifiedIdentityCode
        {
            get { return this.unifiedIdentityCode; }
            private set
            {
                if (UnifiedIdentityCodeIsValid(value) == false)
                {
                    throw new ArgumentException("Invalid Unified Identity Code");
                }
                this.unifiedIdentityCode = value;
            }
        }

        //Personal Id Number validation mathod

        private bool UnifiedIdentityCodeIsValid(string number)
        {
            if (string.IsNullOrEmpty(number) || (number.Length < 9 || number.Length > 13))
            {
                return false;
            }

            for (int i = 0; i < number.Length; i++)
            {
                if (!char.IsDigit(number[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
