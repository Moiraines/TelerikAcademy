namespace GSM
{
    using System;
    using System.Collections.Generic;
    public class GSM
    {
        private string model; //Task 1
        private string manufacturer; //Task 1
        private decimal price; //Task 1
        private string owner; //Task 1
        private Battery battery; //Task 1
        private Display display; //Task 1
        private static GSM iPhone4S; //Task 6
        private List<Call> callHistory; //Task 9

        //Task 2 - base constructor
        public GSM(string model, string manufacturer) 
            : this(model, manufacturer, 0.0M, null, new Battery(), new Display(), new List<Call>())
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        //Task 2 - Full constructor with all parameters
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display, List<Call> callHistory)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
            this.callHistory = callHistory;
        }

        static GSM()
        {
            IPhone4S = new GSM("4S", "iPhone", 1000.0M, "Az", new Battery(), new Display(), new List<Call>());
        }

        //Task 6 - property

        public static GSM IPhone4S
        {
            get { return iPhone4S; }
            private set { iPhone4S = value; }
        }

        ////Task 5 - set the properties

        public string Model
        {
            get { return this.model; }
            private set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentOutOfRangeException("Model value should not be empty");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            private set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentOutOfRangeException("Manufacturer value should not be empty");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public decimal Price
        {
            get { return this.price; }
            private set
            {
                if (value <= 0 || value > 1000)
                {
                    throw new ArgumentOutOfRangeException("Value should be more then 0 and less then 1000");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner
        {
            get { return this.owner; }
            private set
            {
                if (value.Length == 0 || value.Length > 40)
                {
                    throw new ArgumentOutOfRangeException("Owner name should be between 0 and 40 symbols");
                }
                else
                {
                    this.owner = value;
                }
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            private set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            private set { this.display = value; }   
        }


        //Task 9

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            private set { this.callHistory = value; }
        }

        //Task 4
        public override string ToString()
        {
            return String.Format("Model: {0}\nManufacturer: {1}\nPrice: {2}\nOwner: {3}\nBattery: {4}\nDisplay: {5}", this.model, this.manufacturer, this.price, this.owner, this.Battery.ToString(), this.Display.ToString());
        }

        //Task 10

        public List<Call> AddCalls(Call element)
        {
            this.callHistory.Add(element);
            return this.callHistory;
        }

        public List<Call> DellCalls(Call element)
        {
            this.callHistory.Remove(element);
            return this.callHistory;
        }

        public List<Call> ClearHistory()
        {
            this.callHistory.Clear();
            return this.callHistory;
        }

        //Task 11

        public decimal CalculateTotalPrice(decimal price)
        {
            decimal callsDuration = 0.0M;
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                callsDuration += callHistory[i].Duration;
            }
            decimal totalPrice = (callsDuration / 60) * price;

            return totalPrice;
        }

        public string PrintCallHistory()
        {
            return String.Format("Calls history:\n{0}", string.Join(Environment.NewLine, this.callHistory));
        }
    }
}
