using System;

namespace Task01
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount savingAccount = new SavingBankAccount("Sarvesh", "S12345");
            BankAccount currentAccount = new CurrentBankAccount("Mark", "C12345");

            savingAccount.Deposit(40000);
            savingAccount.Deposit(50001);
            savingAccount.Withdraw(1000);
            savingAccount.Withdraw(1000);
            savingAccount.Withdraw(40000);
            savingAccount.Withdraw(1000);
            savingAccount.Withdraw(1000);



            // Generate Report
            savingAccount.GenerateAccountReport();

            Console.WriteLine();
            currentAccount.Deposit(190000);
            currentAccount.Withdraw(10000000);
            currentAccount.GenerateAccountReport();

            Console.ReadLine();
        }
    }
}
