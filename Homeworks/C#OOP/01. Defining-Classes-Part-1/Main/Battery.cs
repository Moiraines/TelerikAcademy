using System;
namespace GSM
{
    public class Battery
    {
        private string model; //task 1
        private int hoursIdle; //task 1
        private int hoursTalk; //task 1
        private BatteryType type; //task 3

        //task 2

        //Base Constructor
        public Battery()
            : this("Basic", 1, 1, BatteryType.LithiumIonPolymer)
        {
        }

        //Full Constructor
        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType type)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.type = type;
        }

        //Task 5 - set the properties

        public string Model
        {
            get { return this.model; }
            private set 
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentOutOfRangeException("Model value should not be empty");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public int HoursIdle
        {
            get { return this.hoursIdle; }
            private set 
            {
                if (value <= 0 || value >200)
                {
                    throw new ArgumentOutOfRangeException("Hours iddle should be longer then 0 and shorter then 200");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public int HoursTalk
        {
            get { return this.hoursTalk; }
            private set 
            {
                if (value <= 0 || value > 60)
                {
                    throw new ArgumentOutOfRangeException("Hours talk should be betwween 0 and 60 mins");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public BatteryType Type
        {
            get { return this.type; }
            private set 
            {      
                this.type = value;
            }
        }

        //Task 4

        public override string ToString()
        {
            return String.Format("Model: {0}\nHours idle: {1}\nHours talk: {2}\nType: {3}", this.model, this.hoursIdle, this.hoursTalk, this.type);
        }
    }
}
