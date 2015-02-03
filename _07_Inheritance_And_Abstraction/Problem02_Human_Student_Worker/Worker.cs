using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_Human_Student_Worker
{
    class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("salary can't be negative");
                }
                else
                { 
                    this.weekSalary = value;
                }
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("work hours can't be negative");
                }
                else
                {
                    this.workHoursPerDay = value;
                }
            }
        }

        public Worker(string fname, string lname, decimal salary, int hours)
            :base(fname, lname)
        {
            this.WeekSalary = salary;
            this.WorkHoursPerDay = hours;
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5);
        }
    }
}
