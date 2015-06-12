namespace BankOfKurtovoKonare
{
    class Mortage : Account
    {
        public Mortage(Customer customer, decimal balance, decimal interest)
        {
            base.Customer = customer;
            base.Balance = balance;
            base.InterestRate = interest;
        }

        public new Customer Customer => base.Customer;


        public override decimal CalcInterestRate(decimal money, int months)
        {
            if (Customer.AccountType.Individual == this.Customer.Type)
            {
                months -= 6;
            }
            decimal interest = base.CalcInterestRate(money, months);
            return Customer.Type == Customer.AccountType.Individual ? interest : months < 0 ? 0 : months <= 12 ? interest / 2 : interest - interest / 2;
        }
    }
}
