namespace GSM
{
    using System;
    public class Call //Task 8
    {

        private DateTime date;
        private string phoneNumber;
        private ulong duration;

        public Call(DateTime date, string phoneNumber, ulong duration)
        {
            this.date = date;
            this.phoneNumber = phoneNumber;
            this.duration = duration;
        }

        public DateTime Date
        {
            get { return this.date; }
            private set { this.date = value; }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            private set { this.phoneNumber = value; }
        }

        public ulong Duration
        {
            get { return this.duration; }
            private set { this.duration = value; }
        }

        public override string ToString()
        {
            return String.Format("Date and time of Call: {0}\nDuration of Call in seconds: {1}\nPhone number: {2}", this.date, this.duration, this.phoneNumber);
        }
    }
}
