using System;

namespace BankOfKurtovoKonare
{
    class Deposit : Account
    {
        public Deposit(Customer customer,decimal balance, decimal interest)
        {
            base.Customer = customer;
            base.Balance = balance;
            base.InterestRate = balance > 1000 ? interest : 0;
        }

        public new Customer Customer => base.Customer;

        public override void DepositMoney(decimal money)
        {
            this.Balance += money;
        }

        public void Widthdraw(decimal money)
        {
            this.Balance -= money;
        }
    }
}
