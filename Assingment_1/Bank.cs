using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assingment_1
{
    class Bank
    {
        private string bankName;
        //private double balance;
      
        private Account[] accounts;
        public Bank(string bankName, int size)
        {
            this.bankName = bankName;
            accounts = new Account[size];
        }
        public string Name
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }
        public Account[] Accounts
        {
            set { this.accounts = value; }
            get { return this.accounts; }
        }

        public void PrintAllAccounts()
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                accounts[i].PrintAccount();
            }
        }
                          //Add Account
        public void AddAccount(Account account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    break;
                }
            }
        }
        //Delete Account
        public void DeleteAccount(int accNumber)
        {

            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                else if (accounts[i].AccountNumber == accNumber)
                {

                    for (int j = i; j < accounts.Length; j++)
                    {
                        if (j < accounts.Length - 1)
                        {
                            accounts[j] = null;
                            accounts[j] = accounts[j + 1];
                        }
                        else
                        {
                            accounts[j] = null;
                        }
                    }
                    Console.WriteLine("Account successfully deleted");
                    break;
                }
            }
        }
        
      

    }
}
