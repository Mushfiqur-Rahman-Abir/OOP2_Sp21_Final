using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTransaction
{
    class Transaction:Account
    {
        public Account sender { get; set; }
        public Account receiver { get; set; }
        public int amount { get; set; }
        public string additionalInfo { get; set; }

        public Transaction()
        {
            Console.WriteLine("Deafult Transaction.");
        }
        public Transaction(Account sender, Account receiver, int amount, string additionalInfo)
        {
            this.sender = sender;
            this.receiver = receiver;
            this.amount = amount;
            this.additionalInfo = additionalInfo;
        }

        override public void showInfo()
        {
            Console.WriteLine("Sender is: " + sender.AccName);
            Console.WriteLine("Receiver is: " + receiver.AccName);
            Console.WriteLine("Amount is: " + amount);
            Console.WriteLine("Additional Info: " + additionalInfo);
        }
    }
}
