namespace _02.StudentsAndWorkers
{
    using System;
    public class Worker : Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary 
        {
            get { return this.weekSalary; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("TheSalary cannot be lesser then 0");
                }
                this.weekSalary = value;
            } 
        }
        public double WorkHoursPerDay 
        {
            get { return this.workHoursPerDay; }
            private set
            {
                if (value < 2 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("Working hours per day should not be lesser then two and longer then 10");
                }
                this.workHoursPerDay = value;
            }  
        }

        public decimal MoneyPerHour()
        {
            decimal result = (this.WeekSalary / 5) / (decimal)this.WorkHoursPerDay;

            return result;
        }
    }
}
