using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assingment_1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Bank ourBank = new Bank("Dhaka_Bank", 5);
            ourBank.AddAccount(new Account(123456, "Sourav", 10000, new Address(4, 10, "Dhaka", "Bangladesh")));
            ourBank.AddAccount(new Account(789123, "Nadim", 3000, new Address(4, 10, "Mymenshing", "Bangladesh")));
            ourBank.AddAccount(new Account(456789, "Sabbir", 6000, new Address(7, 20, "Khulna", "Bangladesh")));
            ourBank.DeleteAccount(789123);
           


            ourBank.PrintAllAccounts();
        }
    }
}
