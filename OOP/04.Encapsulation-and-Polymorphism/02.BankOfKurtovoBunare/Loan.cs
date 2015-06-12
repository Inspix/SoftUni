namespace BankOfKurtovoKonare
{
    class Loan : Account
    {
        public Loan(Customer customer, decimal balance, decimal interest)
        {
            base.Customer = customer;
            base.Balance = balance;
            base.InterestRate = interest;
        }

        public new Customer Customer => base.Customer;

        public override decimal CalcInterestRate(decimal money, int months)
        {
            switch (this.Customer.Type)
            {
                    case Customer.AccountType.Individual:
                    months -= 3;
                    break;
                    case Customer.AccountType.Company:
                    months -= 2;
                    break;
            }

            return months <= 0 ? 0 : base.CalcInterestRate(money, months);
        }
        

    }
}
