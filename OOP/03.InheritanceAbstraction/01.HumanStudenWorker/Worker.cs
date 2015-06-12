using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudenWorker
{
    class Worker : Human
    {
        private float workHoursPerDay;
        private decimal weeklySalary;


        public Worker(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public Worker(string firstName, string lastName, float workHours, decimal salary) : base (firstName,lastName)
        {
            this.WorkHoursPerDay = workHours;
            this.WeeklySalary = salary;
        }

        public float WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Work hours per day should be greater than 0..");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal WeeklySalary
        {
            get { return this.weeklySalary; }
            set {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The salary should be positive number");
                }
                this.weeklySalary = value;
            }
        }


        public decimal MoneyPerHour()
        {
            return Math.Round(weeklySalary/5/(decimal)workHoursPerDay,2);
        }

        public override string ToString()
        {
            return base.ToString() +
                   string.Format("\nWork ours per day: {0}\nWeekly salary: {1}", this.workHoursPerDay, this.weeklySalary);
        }
    }
}
