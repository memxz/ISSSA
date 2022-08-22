using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
	class Program
	{
		static void Main(string[] args)
        {
			bool canWithraw;
			// Test class Account by creating an Account object
			// and call methods to make sure your code at 
			// class Account work


			// TODO. Create object
			// 1. Create a new Account object account1
			// - accNumber: S0000111
			// - acctHolderId: S1111111A
			// - balance: 2000
			// 2. Call Console.WriteLine(account1)
			// Make sure that the account information 
			// is displayed correctly
			//Account ac = new Account("S0000111","S1111111A",2000);
   //         Console.WriteLine(ac.ToString());

   //         // TODO: Deposit
   //         // Deposit 200 to the acccount.
   //         // Display the account information again and 
   //         // manually verify the new balance
   //         ac.Deposit(200);
   //         Console.WriteLine(ac.ToString());

   //         // TODO: Widthdraw
   //         // Withdraw 200 from the account.
   //         // Display the account information again and
   //         // manually verify the new balance
   //         ac.Withdraw(200);
   //         Console.WriteLine(ac.ToString());


   //         // TODO: Widthdraw
   //         // Withdraw 4000 from the account.
   //         // Make sure that the withdrawing is unsuccessful.
   //         ac.Withdraw(4000);
   //         Console.WriteLine(ac.ToString());
   //         Console.ReadLine();

			///**
   //       * TODO: create objects of each type of accounts 
   //       * and call methods to test.
   //       * 
   //       * You many uncomment each part of the following 
   //       * code to use for your testing. You're encouraged
   //       * to add your own test cases.
   //       */

			////bool canWithraw;
			//// Test Saving Accounts

			//SavingsAccount savingAccount = new SavingsAccount("S0000111", "S1111111A", 2000);
			//Console.WriteLine(savingAccount.ToString());
			//Console.WriteLine("Interest: {0}", savingAccount.CalculateInterest());
			//savingAccount.CreditInterest();
			//Console.WriteLine(savingAccount.ToString());
			//canWithraw = savingAccount.Withdraw(3000);
			//if (canWithraw)
			//{
			//   Console.WriteLine("Withraw 3000 ok");
			//}
			//else
			//{
			//   Console.WriteLine("Withraw 3000 fails");
			//}

			//Console.WriteLine();



			//// Test Current Accounts

			//CurrentAcount currentAccount = new CurrentAcount("S0000333", "S3333333B", 2000);
			//Console.WriteLine(currentAccount.ToString());
			//Console.WriteLine("Interest: {0}", currentAccount.CalculateInterest());
			//currentAccount.CreditInterest();
			//Console.WriteLine(currentAccount.ToString());
			//canWithraw = currentAccount.Withdraw(3000);
			//if (canWithraw)
			//{
			//   Console.WriteLine("Withraw 3000 ok");
			//}
			//else
			//{
			//   Console.WriteLine("Withraw 3000 fails");
			//}
			//Console.WriteLine();



			//// Test Overdraft Accounts

			//OverdraftAccount overdraftAccount1 = new OverdraftAccount("S0000222", "S2222222B", 2000);
			//Console.WriteLine(overdraftAccount1.ToString());
			//Console.WriteLine("Interest: {0}", overdraftAccount1.CalculateInterest());
			//overdraftAccount1.CreditInterest();
			//Console.WriteLine(overdraftAccount1.ToString());
			//canWithraw = overdraftAccount1.Withdraw(3000);
			//if (canWithraw)
			//{
			//   Console.WriteLine("Withraw 3000 ok");
			//}
			//else
			//{
			//   Console.WriteLine("Withraw 3000 fails");
			//}
			//Console.WriteLine(overdraftAccount1.ToString());
			//Console.WriteLine();

			//OverdraftAccount overdraftAccount2 = new OverdraftAccount("S0000222", "S2222222B", -2000);
			//Console.WriteLine(overdraftAccount2.ToString());
			//Console.WriteLine("Interest: {0}", overdraftAccount2.CalculateInterest());
			//overdraftAccount2.CreditInterest();
			//Console.WriteLine(overdraftAccount2.ToString());
			//Console.WriteLine();

			/**
          * TODO: create a branch, add accounts and  
          * call methods to test.
          * 
          * You many uncomment each part of the following 
          * code to use for your testing. You're encouraged
          * to add your own test cases.
          */

			Account savingAccount = new SavingsAccount("0000111", "S1111111A", 2000);
			Console.WriteLine(savingAccount.ToString());
			Account currentAccount = new CurrentAccount("0000222", "S2222222B", 2000);
			Console.WriteLine(currentAccount.ToString());
			Account overdraftAccount1 = new OverdraftAccount("0000333", "S3333333C", 2000);
			Console.WriteLine(overdraftAccount1.ToString());
			Account overdraftAccount2 = new OverdraftAccount("0000444", "S1111111A", -2000);
			Console.WriteLine(overdraftAccount2.ToString());

			BankBranch branch = new BankBranch("KOKO Bank Branch");
			branch.AddAccount(savingAccount);
			branch.AddAccount(currentAccount);
			branch.AddAccount(overdraftAccount1);
			branch.AddAccount(overdraftAccount2);

			Console.WriteLine();
			Console.WriteLine("Print all accounts");
			branch.PrintAccounts();

			Console.WriteLine();
			Console.WriteLine("Total deposits: {0}", branch.TotalDeposits());
			Console.WriteLine("Total interest paid: {0}", branch.TotalInterestPaid());
			Console.WriteLine("Total interest earned: {0}", branch.TotalInterestEarned());

			Console.WriteLine();
			Console.WriteLine("Print all customers");
			branch.PrintCustomers();

			Console.ReadLine();
		}
	}
}
