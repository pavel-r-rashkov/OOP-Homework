using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_Fraction_Calculator
{
    struct Fraction
    {
        public long Numerator { get; set; }
        private long denominator;
        
        public long Denominator
        {
            get { return this.denominator; }
            set
            {
                if(value == 0) 
                {
                    throw new ArgumentException("denominator cant' be 0");
                }
                else
                {
                    this.denominator = value;
                }
            }
        }

        public Fraction(long numerator, long denominator)
            :this()
        {
            this.Numerator = numerator;
            this.denominator = denominator;
        }

        public static Fraction operator + (Fraction first, Fraction second)
        {
            return new Fraction(first.Numerator * second.Denominator + second.Numerator * first.Denominator, first.Denominator * second.Denominator);
        }

        public static Fraction operator - (Fraction first, Fraction second)
        {
            return new Fraction(first.Numerator * second.Denominator - second.Numerator * first.Denominator, first.Denominator * second.Denominator);
        }

        public override string ToString()
        {
            return (this.Numerator / (decimal)this.Denominator).ToString();
        }
    }
}
