using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assingment_1
{
    class Account
    {
        private int accNumber;
        private string accountName;
        private double balance;
        private Address address;
        private int transaction;

        public Account(int accNumber, string accountName, double balance, Address address)
        {
            this.accNumber = accNumber;
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
        }
        public int AccountNumber
        {
            set { this.accNumber = value; }
            get { return this.accNumber; }
        }

        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public int AccountTransfer
        {
            get { return this.transaction; }
        }
        public void withdraw(double amount)
        {
            if (amount > 0)
            {
                this.balance = balance - amount;
                this.transaction++;
            }
        }
        public void deposite(int amount)
        {
            if (amount > 0)
            {
                this.balance = balance + amount;
                this.transaction++;
            }
        }
        public void Transfer(Account reciever, int amount)
        {
            this.withdraw(amount);
            reciever.deposite(amount);
        }



        public void PrintAccount()
        {
          
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}", this.accNumber, this.accountName, this.balance);
            this.address.PrintAddress();
        }
    }
}
