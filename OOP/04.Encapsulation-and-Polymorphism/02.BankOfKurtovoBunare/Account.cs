using System;

namespace BankOfKurtovoKonare
{
    internal abstract class Account : IAccount
    {
        private decimal interestRate;

        public Customer Customer { get; set; }

        public decimal Balance { get; set; }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The interest should be positive number or 0");
                }
                this.interestRate = value;
            }
        }

        public virtual void DepositMoney(decimal money)
        {
            this.Balance -= money;
        }

        public virtual decimal CalcInterestRate(decimal money, int months)
        {
            return money*(1 + this.interestRate * months);
        }
    }
}
