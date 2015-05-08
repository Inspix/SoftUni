/* Problem: A bank account has a holder name (first name, middle name and last name), 
 * available amount of money (balance), bank name, IBAN, 3 credit card 
 * numbers associated with the account. Declare the variables needed to 
 * keep the information for a single bank account using the appropriate 
 * data types and descriptive names.*/

namespace BankAccountData
{
    internal class BankAccountData
    {
        private static void Main(string[] args)
        {
            string firstName;
            string middleName;
            string lastName;
            /* or you can use
            string[] names = new string[3];
            */
            decimal balance;
            string bankName;
            string IBAN;
            long cardNumber;
            long cardNumber2;
            long cardnumber3;
            /* or you can use
            long[] cardNumbers = new long[3];
            */
        }
    }
}