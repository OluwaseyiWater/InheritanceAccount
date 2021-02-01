using System;
using System.Globalization;

namespace InheritanceAccount
{
   public class Program
    {
        static void Main(string[] args)

        {
            IFormatProvider currencyFormat = new CultureInfo("HA-LATN-NG");
            Account account = new Account("Oluwaseyi", "Giwa", "1234567890", 5000M);
            Console.WriteLine("Welcome {0} {1} {2}  Your Balance is N{3}", account.FirstName, account.LastName, account.BvnNumber, account.Balance);
            Console.WriteLine();


            

            SavingsAccount sa = new SavingsAccount(account.FirstName,account.LastName,account.BvnNumber,account.Balance, 0.05M);
            decimal totalCredit = 2000.0M;

            Console.WriteLine("Beginning balance is N{0}", account.Balance);
            totalCredit = sa.CalculateInterest();
            Console.WriteLine("Total interest: N{0}", totalCredit);
            sa.Credit(totalCredit);
            var balance = $"{string.Format(currencyFormat, "{0:C}", sa.Balance)}";
            Console.WriteLine($"Ending balance is: {balance}");
            Console.WriteLine();

            CheckingAccount ca = new CheckingAccount(5000.00M, 30.00M);
            Console.WriteLine("Beginning balance is N{0}", account.Balance);
            ca.Credit(2000.00M);
            ca.Debit(3000.00M);
            Console.WriteLine("Ending balance is N{0}", ca.Balance);

            Console.ReadLine();
        }
    }
}
