using System;

namespace _02.FractionCalculator
{
    public struct Fraction
    {
        public Fraction(long numerator, long denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        private long denominator;

        public long Numerator { get; set; }

        public long Denominator
        {
            get { return this.denominator; } 
            set { this.denominator = value; }
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction x = new Fraction
            {
                Numerator = a.Numerator*b.Denominator + b.Numerator*a.Denominator,
                Denominator = a.Denominator*b.Denominator
            };
            return x;
        }

        public override string ToString()
        {
            return (Numerator/(decimal)Denominator).ToString();
        }
    }
}
