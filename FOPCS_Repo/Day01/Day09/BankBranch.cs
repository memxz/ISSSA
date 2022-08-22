using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    public class BankBranch
    {
        //
        // This attributes keep a list of bank accounts.
        // Any type of accounts will be accepted
        // 
        private List<Account> _accounts;

        public BankBranch(string name)
        {
            Name = name;
            _accounts = new List<Account>();
        }

        // Auto-properties
        public string Name { get; set; }

        /**
         * TODO: Implement method AddAccount()
         * This method helps this bank branch keeps another
         * bank account, by adding a given Account object to the
         * _accounts list.
         * 
         * For more information about how to use List, refer
         * to https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netcore-3.1#examples
         */
        public void AddAccount(Account account)
        {
            // Hint: this method only has 1 
            // line of code
            _accounts.Add(account);
        }

        /**
         * This method prints the information of all 
         * the accounts' that this branch keeps
         */
        public void PrintAccounts()
        {
            foreach (Account account in _accounts)
            {
                Console.WriteLine(account);
            }
        }

        /**
         * TODO: Implement method TotalDeposits
         * This method returns the total non-negative
         * balance of all accounts that this branch
         * keeps
         */
        public double TotalDeposits() {
            double total=0;
            foreach (Account account in _accounts)
            {
                total += account.Balance;
            }
            return total;
        }




        /**
         * TODO: Implement method TotalInterestPaid()
         * 
         * Every year, each account which has 
         * non-negative balance kept in this branch
         * will be paid its respective interest, computed
         * by the account's CalculateInterest() method
         * 
         * This method returns the sum of  
         * interests that this branch pays to 
         * all non-negative balance accounts it keeps 
         */
        public double TotalInterestPaid() {
            double interest = 0;
            foreach (Account account in _accounts)
            {
                interest+= account.Balance<0?0:account.CalculateInterest();
            }
            return interest;
        }


        /**
         * TODO: Implement method TotalInterestEarned()
         * 
         * Every year, each account which has
         * negative balance will pay its respective 
         * interest, computed by the account's 
         * CalculateInterest() method
         * 
         * This method returns the sum of negative 
         * interests that this branchs earns from 
         * all negative-balance accounts it keeps 
         */
        public double TotalInterestEarned()
        {
            double interest = 0;
            foreach (Account account in _accounts)
            {
                interest += account.Balance < 0 ? account.CalculateInterest() :0 ;
            }
            return interest;
        }



        /**
         * TODO: Implement method PrintCustomers()
         * 
         * As we know, each account has attribute
         * to keep the respective holder id
         * 
         * This method prints all UNIQUE holder ids
         * of all accounts that this branch keeps.
         * Note that a customer can hold multiple
         * accounts
         * 
         */
        public void PrintCustomers() {
            foreach (Account account in _accounts)
            {
               Console.WriteLine("A/C ID: "+ account.AcctHolderId);
            }
        }
    }
}
