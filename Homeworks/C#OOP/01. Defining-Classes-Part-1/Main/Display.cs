using System;
namespace GSM
{
    public class Display
    {
        private decimal size; //task 1
        private long numberOfColors; //task 1

        //task 2

        //Default Constructor with default values for the fields
        public Display()
            : this(4.8M, 256)
        {

        }
        //Full constructor
        public Display(decimal size, long numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        //Task 5 - set the properties

        public decimal Size
        {
            get { return this.size; }
            private set 
            {
                if (value <= 0 || value > 8)
                {
                    throw new ArgumentOutOfRangeException("Size should be between 0 and 8 included!"); 
                }
                else
                {
                    this.size = value;
                } 
            }
        }

        public long NumberofColors
        {
            get { return this.numberOfColors; }
            private set
            {
                if (value < 256 || value > long.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("Number of colors should be between 256 and long.MaxValue!");
                }
                else
                {
                    this.numberOfColors = value;
                }
            }
        }

        //Task 4
        public override string ToString()
        {
            return String.Format("Size: {0}\nNumber of Colors: {1}", this.size, this.numberOfColors);
        }


    }
}
