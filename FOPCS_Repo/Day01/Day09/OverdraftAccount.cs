using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
	class OverdraftAccount:Account
	{

        /**
       * TODO: attributes
       * Add instance or static attribute when neccessary
       */
        static double penalty=0.06;



        /**
         * TODO: create a constructor that accepts 3
         * parametes. The constructor should make use
         * of its parent's constructor to initialize
         * its attributes
         */
        public OverdraftAccount(string acctNumber, string acctHolderId, double balance) : base(acctNumber, acctHolderId, balance) { }




        /**
         * TODO: implement method CalculateInterest
         * The method return the interest of this account.
         * 
         * Overdraft Account earns 0.25% interest for postive 
         * balance and pays 6% interest for negative balance.
         * In the latter case, this method may return a 
         * negative number.
         * 
         * You may need to override this method from
         * its parent if neccessary. You may even consider moving
         * the whole method to its parents if possible.
         */

        public override double CalculateInterest()
        {
            if (base.Balance < 0)
            {
                
                return base.Balance*0.06;
            }
            else
            {

                return base.Balance * 0.0025;
            }
        }



        /**
         * TODO: implement method CreditInterest
         * The method deposit the interst amount, returns by
         * CalculateInterest() method of this
         * account to its balance.
         * 
         * You may need to override this method from
         * its parent if neccessary. You may even consider moving
         * the whole method to its parents if possible.
         */
        public override void CreditInterest()
        {
            if (base.Balance < 0)
            {
                base.Balance *= 0.94;
            }
            else
            {
                base.Balance *= 1.0025; 
            }

        }



        /**
         * TODO: override method Widthraw
         * This method decreases the account balance
         * by the given amount. 
         * For a Overdraft Account, balance can be negative
         * 
         * You may need to override this method from
         * its parent if neccessary. You may even consider moving
         * the whole method to its parents if possible.
         */
        public override bool Withdraw(double amt)
        {
                base.Balance -= amt;
                return true;
        }



        /**
         * TODO: override method ToString
         * This method returns the values of the attributes
         * of the current object in a more readable format
         * For example: 
         * (OverdraftAccount) Account: accountNumber=S0000111, accountHolder=S1111111A, balance=2000
         * 
         * This method should make use of its parent's method
         */
        public override string ToString()
        {
            return string.Format("OverdraftAccount {0}", base.ToString());

        }
    }
}
