using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_Interest_Calculator
{
    class InterestCalculator
    {
        private decimal money;
        private decimal interest;
        private int years;
        private Func<decimal, decimal, int, decimal> CalculateInterest;

        public decimal Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if(value < 0) 
                {
                    throw new ArgumentOutOfRangeException("Money can't be negative");
                }
                else
                {
                    this.money = value;
                }
            }
        }

        public decimal Interest
        {
            get
            {
                return this.interest;
            }
            set
            {
                if(value < 0) 
                {
                    throw new ArgumentOutOfRangeException("Interest can't be negative!");
                }
                else
                {
                    this.interest = value;
                }
            }
        }

        public int Years
        {
            get
            {
                return this.years;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Years can't be negative!");
                }
                else
                {
                    this.years = value;
                }
            }
        }

        public InterestCalculator(decimal money, decimal interest, int years, Func<decimal, decimal, int, decimal> a)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.CalculateInterest = a;
        }

        public string Calculate()
        {
            return String.Format("{0:0.0000}", this.CalculateInterest(this.Money, this.Interest, this.Years));
        }

        public static decimal GetSimpleInterest(decimal money, decimal interest, int years) 
        {
            return money * (1 + interest * years);
        }

        public static decimal GetCompoundInterest(decimal money, decimal interest, int years)
        {
            return (decimal)((double)money * Math.Pow((1 + (double)interest / 12), years * 12));
        }

        
    }
}
