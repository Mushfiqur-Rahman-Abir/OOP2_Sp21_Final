using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class CurrentAccount:Account
    {
        public CurrentAccount()
        {

        }
        public CurrentAccount(string accName, string accNo, double balance):base(accName, accNo, balance)
        {

        }

        public override void Withdraw(double amount)
        {
            if(amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Transaction Completed!!! \n Amount: {0}",amount);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
        override public void Transfer(Account acc, double amount)
        {
            if(amount <= Balance)
            {
                this.Balance -= amount;
                acc.Balance += amount;
                Console.WriteLine("Balance Transfered By {0} TK to \n Account name: {1}\n Account no:{2}",amount,acc.AccName, acc.AccNo);
            }
        }
    }
}
