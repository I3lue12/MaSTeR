using System;
using System.Collections.Generic;
using System.Text;

namespace Library_learning
{
    public abstract class Account//prevents instantiation. 
    {

        //private Customer mCustomer;//can member variables go through the get and set propertie?

        protected Customer mCustomer;//protected is for member who inherit from account can access mCustomer.
                                     //if private none of the classes that descent from account have access to mCustomer.
        abstract public void DoStuff();
        protected double balance;
        protected Customer ACustomer;
        protected Account()//still need for it to work
        {

        }

        public Account(double initualAmount,Customer c)
        {
            balance = initualAmount;
            ACustomer = c;
        }
        #region        
        public void Withdraw(double withdrawAmount)
        {
            balance -= withdrawAmount;
            if(balance < 0)
            {
                BalanceOverdrawException e = new BalanceOverdrawException("The account got overdrawn.");
                throw e;
            }
        }

        public void Deposit(double depos)
        {
            balance += depos;
        }
        public double ReturnBalance()
        {
            return balance;
        }
        #endregion //this is the same as
        //this
        //public double Withdraw_Deposit_Balance
        //{
        //    set
        //    {
        //        balance = value;
        //    }
        //    get
        //    {
        //        return balance;
        //    }
        //}

    }
}
