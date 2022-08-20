using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
	public class Account
	{
        /**
       * TODO: create attributes
       * This class has 3 attributes:
       * acctNumber : string, private
       * acctHolderId : string, private
       * balance: double, private
       */

        private string acctNumber;
        private string acctHolderId;
        private double balance;

        public Account() { }

        /**
         * TODO: create constructor
         * This contructor receives 3 values
         * and initializes the 3 attributes accordingly
         */
        public Account(string acctNumber, string acctHolderId, double balance)
        {
            this.acctNumber = acctNumber;
            this.acctHolderId = acctHolderId;
            this.balance = balance;
        }

        /**
         * TODO: create properties
         * These properties expose the private attributes
         *
         * Note: acctNumber should be read-only, i.e. can not be
         * set from outside
         */
        public string AcctNumber { get => acctNumber; set => acctNumber = value; }
        public string AcctHolderId { get => acctHolderId; set => acctHolderId = value; }
        public double Balance { get => balance; set => balance = value; }



        /**
         * TODO: implement method Deposit
         * This method increases the account balance 
         * by the given amount
         */
        public void Deposit(double amt)
        {
            this.balance += amt;
        }



        /**
         * TODO: implement method Withdraw
         * This method decreases the account balance
         * by the given amount. Balance must NOT be negative.
         * It makes sure that there is enough balance to
         * widthdraw
         */
        public virtual bool Withdraw(double amt)
        {

            if (this.balance < amt)
            {
                Console.WriteLine("The balance is not enough to make this transaction");
                return false;
            }
            else {
                this.balance -= amt;
                return true;
            }
                
                
        }



        /**
         * TODO: implement method TransferTo
         * This method transfers a given amount to another given 
         * account. It makes sure that this sender has enough
         * balance before transfering
         */
        public void TransferTo(double amt, Account another)
        {
            if (this.balance < amt)
            {
                Console.WriteLine("The balance is not enough to make this transaction");
            }
            else
                this.balance -= amt;
                another.balance += amt;

        }



		/**
         * TODO: override method ToString
         * This method returns the values of the attributes
         * of the current object in a more readable format
         * For example: 
         * Account: accountNumber=S0000111, accountHolder=S1111111A, balance=2000
         */
		public override string ToString()
		{
            return "A/C Number: " + this.AcctNumber + "\n" + "A/C ID: " + this.AcctHolderId + "\n" + "A/C Balance: " + this.Balance;

        }




		public virtual double CalculateInterest()
		{
			return -1;
		}
		public virtual void CreditInterest()
		{
		}

    }

}
