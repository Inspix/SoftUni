namespace BankOfKurtovoKonare
{
    internal interface IAccount
    {
        Customer Customer { get; set; }
        decimal Balance { get; set; }
        decimal InterestRate { get; set; }

    }
}
