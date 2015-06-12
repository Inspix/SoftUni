using System;

namespace BankOfKurtovoKonare
{
    class Program
    {
        static void Main(string[] args)
        {
            Deposit x = new Deposit(new Customer("gosho", "goshev", Customer.AccountType.Individual), 1550, 0.01m);
            Mortage b = new Mortage(new Customer("Az", "Toi", Customer.AccountType.Company), 1000, 0.05m);
            Loan l = new Loan(new Customer("Tereza", "Maria", Customer.AccountType.Individual), 5000,0.1m );

            b.DepositMoney(555);
            x.Widthdraw(1000);

            Console.WriteLine(x.CalcInterestRate(x.Balance,25));
            Console.WriteLine(b.CalcInterestRate(b.Balance,25));
            Console.WriteLine(l.CalcInterestRate(l.Balance,36));
        }
    }
}
