namespace BankAccounts
{
    using System;
    public class Individual : Customer
    {
        private string personalIdNumber;

        public Individual(string name, int clientNumber, string adress, string personalIdNumber) 
            : base(name, clientNumber, adress)
        {
            this.PersonalIdNumber = personalIdNumber;
        }

        public string PersonalIdNumber
        {
            get { return this.personalIdNumber; }
            private set
            {
                if (personalIdNumberIsValid(value) == false)
                {
                    throw new ArgumentException("Invalid ID number");
                }
                this.personalIdNumber = value;
            }
        }

        //Personal Id Number validation mathod

        private bool personalIdNumberIsValid(string number)
        {
            if (string.IsNullOrEmpty(number) || number.Length != 10)
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
